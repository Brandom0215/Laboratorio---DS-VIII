Imports System.IO

''' <summary>
''' Formulario principal del sistema: Administración interactiva de listas (ListBox),
''' menús desplegables (ComboBox) y visualización en tiempo real de recursos gráficos (PictureBox).
''' </summary>
Public Class Form1

    ''' <summary>
    ''' Ruta absoluta del directorio donde se encuentran alojadas las imágenes del sistema.
    ''' </summary>
    Private rutaCarpetaRecursos As String = String.Empty

    ' -------------------------------------------------------------------------
    ' INICIALIZACIÓN Y CONFIGURACIÓN DEL FORMULARIO
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Maneja el evento de carga inicial del formulario, configurando la carpeta de recursos
    ''' y la selección predeterminada de los controles.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EstablecerCarpetaRecursosPredeterminada()

            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            End If

            TextBox1.Focus()
            ActualizarEstado("Sistema listo. Seleccione un continente o ingrese un nuevo dato.")
        Catch ex As Exception
            MostrarError("Ocurrió un error al inicializar el formulario.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Determina la ubicación física de la carpeta de imágenes, buscando primero en el directorio
    ''' de ejecución binaria y luego en la ruta relativa del proyecto.
    ''' </summary>
    Private Sub EstablecerCarpetaRecursosPredeterminada()
        Try
            Dim rutaBinaria As String = Path.Combine(Application.StartupPath, "Imagenes")
            Dim rutaProyecto As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Imagenes")

            If Directory.Exists(rutaBinaria) Then
                rutaCarpetaRecursos = Path.GetFullPath(rutaBinaria)
            ElseIf Directory.Exists(rutaProyecto) Then
                rutaCarpetaRecursos = Path.GetFullPath(rutaProyecto)
            Else
                rutaCarpetaRecursos = Application.StartupPath
            End If

            LabelImagePath.Text = "Carpeta activa: " & rutaCarpetaRecursos
        Catch ex As Exception
            rutaCarpetaRecursos = Application.StartupPath
            LabelImagePath.Text = "Carpeta activa: " & rutaCarpetaRecursos
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' SELECCIÓN Y CARGA DE RECURSOS GRÁFICOS
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Responde al cambio de elemento seleccionado en la lista principal (ListBox1),
    ''' actualizando la etiqueta del nombre y cargando la imagen correspondiente.
    ''' </summary>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            If ListBox1.SelectedIndex = -1 OrElse ListBox1.SelectedItem Is Nothing Then
                Label1.Text = "(Ninguno)"
                LiberarImagenPictureBox()
                LabelImagePath.Text = "Ningún elemento seleccionado."
                Return
            End If

            Dim nombreSeleccionado As String = ListBox1.SelectedItem.ToString().Trim()
            Label1.Text = nombreSeleccionado

            CargarImagenRecurso(nombreSeleccionado)
        Catch ex As Exception
            MostrarError("Error al procesar la selección del elemento en la lista.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Carga un archivo de imagen en memoria desde el disco o genera una gráfica de respaldo si no existe.
    ''' </summary>
    ''' <param name="nombreRecurso">Nombre del recurso o continente a visualizar.</param>
    Private Sub CargarImagenRecurso(ByVal nombreRecurso As String)
        Try
            LiberarImagenPictureBox()

            If String.IsNullOrWhiteSpace(nombreRecurso) Then
                LabelImagePath.Text = "Elemento sin nombre válido."
                Return
            End If

            ' Validar que el nombre no contenga caracteres prohibidos por el sistema de archivos
            If nombreRecurso.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 Then
                PictureBox1.Image = GenerarImagenRespaldo(nombreRecurso)
                LabelImagePath.Text = "Nombre con caracteres no válidos. Generada imagen de respaldo."
                ActualizarEstado("El elemento '" & nombreRecurso & "' contiene caracteres no válidos para el sistema de archivos.")
                Return
            End If

            Dim extensiones As String() = {".png", ".jpg", ".jpeg", ".bmp"}
            Dim rutaEncontrada As String = String.Empty

            If Directory.Exists(rutaCarpetaRecursos) Then
                ' 1. Probar combinaciones directas
                For Each ext As String In extensiones
                    Dim rutaPrueba As String = Path.Combine(rutaCarpetaRecursos, nombreRecurso & ext)
                    If File.Exists(rutaPrueba) Then
                        rutaEncontrada = rutaPrueba
                        Exit For
                    End If
                Next

                ' 2. Búsqueda insensible a mayúsculas/minúsculas en el directorio
                If String.IsNullOrEmpty(rutaEncontrada) Then
                    Dim archivosEnCarpeta As String() = Directory.GetFiles(rutaCarpetaRecursos)
                    For Each archivo As String In archivosEnCarpeta
                        Dim nombreSinExt As String = Path.GetFileNameWithoutExtension(archivo)
                        Dim extArchivo As String = Path.GetExtension(archivo).ToLower()

                        If String.Equals(nombreSinExt, nombreRecurso, StringComparison.OrdinalIgnoreCase) AndAlso Array.IndexOf(extensiones, extArchivo) >= 0 Then
                            rutaEncontrada = archivo
                            Exit For
                        End If
                    Next
                End If
            End If

            If Not String.IsNullOrEmpty(rutaEncontrada) Then
                ' Carga mediante MemoryStream y clonación GDI+ para evitar bloqueos de archivos en disco
                Using flujoArchivo As New FileStream(rutaEncontrada, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using flujoMemoria As New MemoryStream()
                        flujoArchivo.CopyTo(flujoMemoria)
                        flujoMemoria.Position = 0
                        Using imagenTemp As Image = Image.FromStream(flujoMemoria)
                            PictureBox1.Image = DirectCast(imagenTemp.Clone(), Image)
                        End Using
                    End Using
                End Using

                LabelImagePath.Text = "Recurso cargado: " & Path.GetFileName(rutaEncontrada)
                ActualizarEstado("Imagen de '" & nombreRecurso & "' cargada exitosamente.")
            Else
                PictureBox1.Image = GenerarImagenRespaldo(nombreRecurso)
                LabelImagePath.Text = "Imagen predeterminada generada (no se encontró archivo en carpeta)."
                ActualizarEstado("No se encontró archivo de imagen para '" & nombreRecurso & "'.")
            End If
        Catch ex As Exception
            LabelImagePath.Text = "Error al leer imagen del recurso."
            MostrarError("No se pudo cargar la imagen para '" & nombreRecurso & "'.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Libera de forma limpia los recursos de memoria ocupados por la imagen actual en el PictureBox.
    ''' </summary>
    Private Sub LiberarImagenPictureBox()
        If PictureBox1.Image IsNot Nothing Then
            Dim imagenAnterior As Image = PictureBox1.Image
            PictureBox1.Image = Nothing
            imagenAnterior.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Genera un mapa de bits dinámico como alternativa visual cuando no se encuentra una imagen física.
    ''' </summary>
    ''' <param name="texto">Texto descriptivo a dibujar dentro de la tarjeta de respaldo.</param>
    ''' <returns>Objeto Bitmap renderizado con el texto ajustado.</returns>
    Private Function GenerarImagenRespaldo(ByVal texto As String) As Bitmap
        If String.IsNullOrWhiteSpace(texto) Then
            texto = "Sin Nombre"
        End If

        Dim mapaBits As New Bitmap(400, 300)
        Using lienzo As Graphics = Graphics.FromImage(mapaBits)
            lienzo.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            lienzo.Clear(Color.FromArgb(30, 41, 59))

            Using pincelBorde As New Pen(Color.FromArgb(59, 130, 246), 3)
                lienzo.DrawRectangle(pincelBorde, 15, 15, 370, 270)
            End Using

            ' Tamaño de fuente adaptativo para prevenir desbordamientos visuales
            Dim tamanioFuente As Single = 22.0F
            If texto.Length > 20 Then
                tamanioFuente = 13.0F
            ElseIf texto.Length > 12 Then
                tamanioFuente = 16.0F
            End If

            Using fuenteTitulo As New Font("Segoe UI", tamanioFuente, FontStyle.Bold)
                Using pincelTexto As New SolidBrush(Color.White)
                    Dim formato As New StringFormat() With {
                        .Alignment = StringAlignment.Center,
                        .LineAlignment = StringAlignment.Center
                    }
                    Dim rectangulo As New Rectangle(20, 40, 360, 150)
                    lienzo.DrawString(texto, fuenteTitulo, pincelTexto, rectangulo, formato)
                End Using
            End Using

            Using fuenteSub As New Font("Segoe UI", 10.0F, FontStyle.Italic)
                Using pincelSub As New SolidBrush(Color.FromArgb(148, 163, 184))
                    Dim formatoSub As New StringFormat() With {.Alignment = StringAlignment.Center}
                    lienzo.DrawString("Recurso registrado en el sistema", fuenteSub, pincelSub, 200, 210, formatoSub)
                End Using
            End Using
        End Using
        Return mapaBits
    End Function

    ' -------------------------------------------------------------------------
    ' OPERACIONES CON LISTBOX (AGREGAR / ELIMINAR)
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Agrega el contenido del cuadro de texto a la lista principal previa validación de duplicados y vacíos.
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nuevoElemento As String = TextBox1.Text.Trim()

            If String.IsNullOrWhiteSpace(nuevoElemento) Then
                MessageBox.Show("Por favor, introduzca un nombre en el cuadro de texto antes de agregar.",
                                "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
                Return
            End If

            If ExisteEnListBox(nuevoElemento) Then
                MessageBox.Show("El elemento '" & nuevoElemento & "' ya existe dentro de la lista.",
                                "Elemento duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.SelectAll()
                TextBox1.Focus()
                Return
            End If

            ListBox1.Items.Add(nuevoElemento)
            TextBox1.Clear()
            TextBox1.Focus()

            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            ActualizarEstado("Se agregó '" & nuevoElemento & "' a la lista principal.")
        Catch ex As Exception
            MostrarError("Ocurrió un problema al agregar el elemento a la lista.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Elimina el elemento seleccionado en la lista principal con confirmación previa.
    ''' </summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If ListBox1.SelectedIndex = -1 OrElse ListBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo.",
                                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim elementoAEliminar As String = ListBox1.SelectedItem.ToString()
            Dim respuesta As DialogResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar el elemento '" & elementoAEliminar & "' de la lista?",
                "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Dim indiceActual As Integer = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(indiceActual)

                If ListBox1.Items.Count > 0 Then
                    If indiceActual < ListBox1.Items.Count Then
                        ListBox1.SelectedIndex = indiceActual
                    Else
                        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                    End If
                Else
                    Label1.Text = "(Ninguno)"
                    LiberarImagenPictureBox()
                    LabelImagePath.Text = "La lista se encuentra vacía."
                End If

                ActualizarEstado("Se eliminó '" & elementoAEliminar & "' de la lista.")
            End If
        Catch ex As Exception
            MostrarError("Ocurrió un problema al eliminar el elemento de la lista.", ex)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' OPERACIONES CON COMBOBOX (AGREGAR / ELIMINAR / TRANSFERIR)
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Agrega un nuevo elemento al menú desplegable (ComboBox1) validando que no sea nulo ni duplicado.
    ''' </summary>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim nuevoElemento As String = TextBox1.Text.Trim()

            If String.IsNullOrWhiteSpace(nuevoElemento) Then
                MessageBox.Show("Por favor, escriba el texto a ingresar en el ComboBox.",
                                "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
                Return
            End If

            If ExisteEnComboBox(nuevoElemento) Then
                MessageBox.Show("El elemento '" & nuevoElemento & "' ya existe en el menú desplegable.",
                                "Elemento duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.SelectAll()
                TextBox1.Focus()
                Return
            End If

            ComboBox1.Items.Add(nuevoElemento)
            ComboBox1.SelectedItem = nuevoElemento
            TextBox1.Clear()
            TextBox1.Focus()

            ActualizarEstado("Se agregó '" & nuevoElemento & "' al ComboBox.")
        Catch ex As Exception
            MostrarError("Ocurrió un problema al agregar el elemento al ComboBox.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Elimina la opción actualmente seleccionada en el menú desplegable tras confirmación.
    ''' </summary>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If ComboBox1.SelectedIndex = -1 OrElse ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Debe seleccionar un elemento del menú desplegable para eliminarlo.",
                                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim elementoAEliminar As String = ComboBox1.SelectedItem.ToString()
            Dim respuesta As DialogResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar '" & elementoAEliminar & "' del ComboBox?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
                If ComboBox1.Items.Count > 0 Then
                    ComboBox1.SelectedIndex = 0
                End If
                ActualizarEstado("Se eliminó '" & elementoAEliminar & "' del ComboBox.")
            End If
        Catch ex As Exception
            MostrarError("Ocurrió un problema al eliminar el elemento del ComboBox.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Transfiere la opción seleccionada en el ComboBox hacia la lista principal ListBox.
    ''' </summary>
    Private Sub ButtonTransferToList_Click(sender As Object, e As EventArgs) Handles ButtonTransferToList.Click
        Try
            If ComboBox1.SelectedIndex = -1 OrElse ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione un elemento del ComboBox para transferirlo al ListBox.",
                                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim elemento As String = ComboBox1.SelectedItem.ToString()

            If ExisteEnListBox(elemento) Then
                ListBox1.SelectedItem = elemento
                MessageBox.Show("El elemento '" & elemento & "' ya existía en la lista. Ha sido seleccionado.",
                                "Elemento ya presente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ListBox1.Items.Add(elemento)
            ListBox1.SelectedItem = elemento
            ActualizarEstado("Transferido '" & elemento & "' desde ComboBox hacia ListBox.")
        Catch ex As Exception
            MostrarError("Error al transferir dato desde ComboBox hacia ListBox.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Transfiere el elemento seleccionado del ListBox hacia el menú desplegable ComboBox.
    ''' </summary>
    Private Sub ButtonTransferToCombo_Click(sender As Object, e As EventArgs) Handles ButtonTransferToCombo.Click
        Try
            If ListBox1.SelectedIndex = -1 OrElse ListBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista para transferirlo al ComboBox.",
                                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim elemento As String = ListBox1.SelectedItem.ToString()

            If ExisteEnComboBox(elemento) Then
                ComboBox1.SelectedItem = elemento
                MessageBox.Show("El elemento '" & elemento & "' ya se encuentra en el ComboBox.",
                                "Elemento existente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ComboBox1.Items.Add(elemento)
            ComboBox1.SelectedItem = elemento
            ActualizarEstado("Transferido '" & elemento & "' desde ListBox hacia ComboBox.")
        Catch ex As Exception
            MostrarError("Error al transferir dato desde ListBox hacia ComboBox.", ex)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' CARPETA DEL SISTEMA, REINICIO Y NAVEGACIÓN
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Permite explorar y seleccionar una carpeta personalizada en el disco para cargar imágenes.
    ''' </summary>
    Private Sub ButtonSelectFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectFolder.Click
        Try
            FolderBrowserDialog1.SelectedPath = rutaCarpetaRecursos
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                rutaCarpetaRecursos = FolderBrowserDialog1.SelectedPath
                LabelImagePath.Text = "Carpeta activa: " & rutaCarpetaRecursos

                If ListBox1.SelectedIndex <> -1 AndAlso ListBox1.SelectedItem IsNot Nothing Then
                    CargarImagenRecurso(ListBox1.SelectedItem.ToString())
                End If

                ActualizarEstado("Nueva carpeta de recursos configurada con éxito.")
            End If
        Catch ex As Exception
            MostrarError("Ocurrió un error al seleccionar la carpeta de recursos.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Restablece la lista de continentes a los datos iniciales predeterminados.
    ''' </summary>
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Try
            Dim respuesta As DialogResult = MessageBox.Show(
                "¿Desea restaurar la lista predeterminada de continentes?",
                "Reiniciar lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ListBox1.Items.Clear()
                ListBox1.Items.AddRange(New Object() {"EUROPA", "OCEANIA", "ANTARTIDA", "AMERICA", "ASIA", "AFRICA"})
                ListBox1.SelectedIndex = 0
                ActualizarEstado("Lista de continentes reiniciada a los valores de fábrica.")
            End If
        Catch ex As Exception
            MostrarError("No fue posible reiniciar la lista de continentes.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Abre el formulario de Menú Principal.
    ''' </summary>
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            My.Forms.Menu.Show()
            My.Forms.Menu.BringToFront()
            ActualizarEstado("Menú principal abierto.")
        Catch ex As Exception
            MostrarError("No fue posible abrir el Menú principal.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Captura la tecla Enter en el campo de entrada de texto para realizar el envío directo.
    ''' </summary>
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1.PerformClick()
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' FUNCIONES AUXILIARES Y VALIDACIONES DE CONTROL
    ' -------------------------------------------------------------------------

    ''' <summary>
    ''' Comprueba si un texto ya está presente en el ListBox ignorando mayúsculas y minúsculas.
    ''' </summary>
    ''' <param name="textoBuscado">Cadena de texto a buscar.</param>
    ''' <returns>True si el elemento existe; de lo contrario, False.</returns>
    Private Function ExisteEnListBox(ByVal textoBuscado As String) As Boolean
        If String.IsNullOrWhiteSpace(textoBuscado) Then Return False
        For Each item As Object In ListBox1.Items
            If item IsNot Nothing AndAlso String.Equals(item.ToString().Trim(), textoBuscado.Trim(), StringComparison.CurrentCultureIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Comprueba si un texto ya está presente en el ComboBox ignorando mayúsculas y minúsculas.
    ''' </summary>
    ''' <param name="textoBuscado">Cadena de texto a buscar.</param>
    ''' <returns>True si el elemento existe; de lo contrario, False.</returns>
    Private Function ExisteEnComboBox(ByVal textoBuscado As String) As Boolean
        If String.IsNullOrWhiteSpace(textoBuscado) Then Return False
        For Each item As Object In ComboBox1.Items
            If item IsNot Nothing AndAlso String.Equals(item.ToString().Trim(), textoBuscado.Trim(), StringComparison.CurrentCultureIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Garantiza la liberación de recursos gráficos en la memoria cuando el formulario se va a cerrar.
    ''' </summary>
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LiberarImagenPictureBox()
    End Sub

    ''' <summary>
    ''' Actualiza la barra de estado inferior con un mensaje informativo para el usuario.
    ''' </summary>
    Private Sub ActualizarEstado(ByVal mensaje As String)
        ToolStripStatusLabel1.Text = mensaje
    End Sub

    ''' <summary>
    ''' Muestra un diálogo emergente con detalles del error capturado.
    ''' </summary>
    Private Sub MostrarError(ByVal mensajeUsuario As String, ByVal excepcion As Exception)
        ActualizarEstado("Error: " & mensajeUsuario)
        MessageBox.Show(mensajeUsuario & vbCrLf & vbCrLf &
                        "Detalle: " & If(excepcion IsNot Nothing, excepcion.Message, "Desconocido"),
                        "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
