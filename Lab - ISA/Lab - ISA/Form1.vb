Imports System.IO

''' <summary>
''' Formulario principal del Laboratorio ISA: Gestión e interacción de
''' controles ComboBox, ListBox y PictureBox con carga dinámica de recursos.
''' </summary>
Public Class Form1

    ' Ruta de la carpeta del sistema donde se encuentran las imágenes de los recursos
    Private rutaCarpetaRecursos As String = String.Empty

    ' =========================================================================
    ' EVENTOS DE INICIALIZACIÓN
    ' =========================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Establecer la carpeta predeterminada de recursos
            EstablecerCarpetaRecursosPredeterminada()

            ' 2. Seleccionar el primer continente de la lista si hay elementos disponibles
            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            End If

            ' 3. Foco inicial en el cuadro de texto para mejorar la usabilidad
            TextBox1.Focus()

            ActualizarEstado("Sistema listo. Seleccione un continente o ingrese un nuevo dato.")
        Catch ex As Exception
            MostrarError("Ocurrió un error al inicializar el formulario.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Configura la ruta de la carpeta de imágenes buscando primero en la carpeta de ejecución
    ''' y luego en la carpeta del proyecto para garantizar disponibilidad en cualquier entorno.
    ''' </summary>
    Private Sub EstablecerCarpetaRecursosPredeterminada()
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
    End Sub

    ' =========================================================================
    ' GESTIÓN DE SELECCIÓN Y CARGA DE RECURSOS (LISTBOX -> PICTUREBOX)
    ' =========================================================================

    ''' <summary>
    ''' Al cambiar la selección en ListBox1, se actualiza Label1 y se carga la imagen correspondiente.
    ''' Cumple con la lógica detallada en las diapositivas 2 y 3.
    ''' </summary>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            If ListBox1.SelectedIndex = -1 Then
                Label1.Text = "(Ninguno)"
                LiberarImagenPictureBox()
                LabelImagePath.Text = "Ningún elemento seleccionado."
                Return
            End If

            Dim nombreSeleccionado As String = ListBox1.SelectedItem.ToString().Trim()
            Label1.Text = nombreSeleccionado

            CargarImagenRecurso(nombreSeleccionado)
        Catch ex As Exception
            MostrarError("Error al procesar la selección del elemento.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Carga la imagen asociada al elemento desde la carpeta de recursos del sistema.
    ''' Utiliza un MemoryStream para evitar bloqueos del archivo en disco.
    ''' </summary>
    Private Sub CargarImagenRecurso(ByVal nombreRecurso As String)
        Try
            LiberarImagenPictureBox()

            ' Extensiones de archivo admitidas
            Dim extensiones As String() = {".png", ".jpg", ".jpeg", ".bmp"}
            Dim rutaEncontrada As String = String.Empty

            For Each ext As String In extensiones
                Dim rutaPrueba As String = Path.Combine(rutaCarpetaRecursos, nombreRecurso & ext)
                If File.Exists(rutaPrueba) Then
                    rutaEncontrada = rutaPrueba
                    Exit For
                End If

                ' Probar también con mayúsculas exactas
                Dim rutaPruebaMayus As String = Path.Combine(rutaCarpetaRecursos, nombreRecurso.ToUpper() & ext)
                If File.Exists(rutaPruebaMayus) Then
                    rutaEncontrada = rutaPruebaMayus
                    Exit For
                End If
            Next

            If Not String.IsNullOrEmpty(rutaEncontrada) Then
                ' Carga en memoria para no retener el bloqueo del archivo
                Using flujoArchivo As New FileStream(rutaEncontrada, FileMode.Open, FileAccess.Read)
                    Using flujoMemoria As New MemoryStream()
                        flujoArchivo.CopyTo(flujoMemoria)
                        flujoMemoria.Position = 0
                        PictureBox1.Image = Image.FromStream(flujoMemoria)
                    End Using
                End Using

                LabelImagePath.Text = "Recurso cargado: " & Path.GetFileName(rutaEncontrada)
                ActualizarEstado("Imagen de '" & nombreRecurso & "' cargada exitosamente.")
            Else
                ' Si no existe imagen específica, generar visual de respaldo
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
    ''' Libera los recursos de imagen asignados previamente al PictureBox.
    ''' </summary>
    Private Sub LiberarImagenPictureBox()
        If PictureBox1.Image IsNot Nothing Then
            Dim imagenAnterior As Image = PictureBox1.Image
            PictureBox1.Image = Nothing
            imagenAnterior.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Genera un gráfico moderno de respaldo cuando no existe archivo físico en disco.
    ''' </summary>
    Private Function GenerarImagenRespaldo(ByVal texto As String) As Bitmap
        Dim mapaBits As New Bitmap(400, 300)
        Using lienzo As Graphics = Graphics.FromImage(mapaBits)
            lienzo.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            lienzo.Clear(Color.FromArgb(30, 41, 59))

            Using pincelBorde As New Pen(Color.FromArgb(59, 130, 246), 3)
                lienzo.DrawRectangle(pincelBorde, 15, 15, 370, 270)
            End Using

            Using fuenteTitulo As New Font("Segoe UI", 22.0F, FontStyle.Bold)
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

    ' =========================================================================
    ' OPERACIONES CON LISTBOX (AGREGAR / ELIMINAR)
    ' =========================================================================

    ''' <summary>
    ''' Button1: Agrega el texto de TextBox1 a ListBox1 con validación previa.
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nuevoElemento As String = TextBox1.Text.Trim()

            ' Validación de campo obligatorio
            If String.IsNullOrWhiteSpace(nuevoElemento) Then
                MessageBox.Show("Por favor, introduzca un nombre en el cuadro de texto antes de agregar.",
                                "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
                Return
            End If

            ' Validación de duplicados
            If ExisteEnListBox(nuevoElemento) Then
                MessageBox.Show("El elemento '" & nuevoElemento & "' ya existe dentro de la lista.",
                                "Elemento duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.SelectAll()
                TextBox1.Focus()
                Return
            End If

            ' Agregar elemento
            ListBox1.Items.Add(nuevoElemento)
            TextBox1.Clear()
            TextBox1.Focus()

            ' Seleccionar el nuevo elemento para desplegar su recurso
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            ActualizarEstado("Se agregó '" & nuevoElemento & "' a la lista principal.")
        Catch ex As Exception
            MostrarError("Ocurrió un problema al agregar el elemento a la lista.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Button2: Elimina el elemento seleccionado en ListBox1 con confirmación de seguridad.
    ''' </summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If ListBox1.SelectedIndex = -1 Then
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

                ' Ajustar selección tras eliminación
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

    ' =========================================================================
    ' OPERACIONES CON COMBOBOX (AGREGAR / ELIMINAR / TRANSFERIR)
    ' =========================================================================

    ''' <summary>
    ''' Button3: Agrega el texto de TextBox1 a ComboBox1 con validación previa.
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
    ''' Button4: Elimina el elemento seleccionado en ComboBox1 tras confirmación.
    ''' </summary>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If ComboBox1.SelectedIndex = -1 Then
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
    ''' Transfiere el elemento actualmente seleccionado en el ComboBox hacia el ListBox.
    ''' Cumple textualmente con: 'EL LISTBOX DEBE RECIBIR DATOS PROVENIENTES DEL COMBOBOX'.
    ''' </summary>
    Private Sub ButtonTransferToList_Click(sender As Object, e As EventArgs) Handles ButtonTransferToList.Click
        Try
            If ComboBox1.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un elemento del ComboBox para transferirlo al ListBox.",
                                "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim elemento As String = ComboBox1.SelectedItem.ToString()

            If ExisteEnListBox(elemento) Then
                ' Si ya existe, lo enfocamos en el ListBox directamente
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
    ''' Transfiere el elemento seleccionado del ListBox hacia el ComboBox.
    ''' </summary>
    Private Sub ButtonTransferToCombo_Click(sender As Object, e As EventArgs) Handles ButtonTransferToCombo.Click
        Try
            If ListBox1.SelectedIndex = -1 Then
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

    ' =========================================================================
    ' CARPETA DEL SISTEMA, REINICIO Y NAVEGACIÓN
    ' =========================================================================

    ''' <summary>
    ''' Permite seleccionar una carpeta del sistema de archivos para cargar recursos.
    ''' Cumple con: 'PROGRAMA QUE CARGUE RECURSOS A PARTIR DE UNA CARPETA DEL SISTEMA'.
    ''' </summary>
    Private Sub ButtonSelectFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectFolder.Click
        Try
            FolderBrowserDialog1.SelectedPath = rutaCarpetaRecursos
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                rutaCarpetaRecursos = FolderBrowserDialog1.SelectedPath
                LabelImagePath.Text = "Carpeta activa: " & rutaCarpetaRecursos

                ' Recargar la imagen del elemento actualmente seleccionado
                If ListBox1.SelectedIndex <> -1 Then
                    CargarImagenRecurso(ListBox1.SelectedItem.ToString())
                End If

                ActualizarEstado("Nueva carpeta de recursos configurada con éxito.")
            End If
        Catch ex As Exception
            MostrarError("Ocurrió un error al seleccionar la carpeta de recursos.", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Restaura los datos predeterminados de la práctica (continentes iniciales).
    ''' Cumple con el criterio de usabilidad para reiniciar datos.
    ''' </summary>
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Desea restaurar la lista predeterminada de continentes?",
            "Reiniciar lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(New Object() {"EUROPA", "OCEANIA", "ANTARTIDA", "AMERICA", "ASIA", "AFRICA"})
            ListBox1.SelectedIndex = 0
            ActualizarEstado("Lista de continentes reiniciada a los valores de fábrica.")
        End If
    End Sub

    ''' <summary>
    ''' Button5: Abre el formulario del Menú Principal como indica la diapositiva 4 (Menu.SHOW()).
    ''' Se utiliza My.Forms.Menu para evitar ambigüedad con la propiedad Menu heredada de Form.
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
    ''' Permite agregar directamente al presionar Enter en el cuadro de texto.
    ''' </summary>
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1.PerformClick()
        End If
    End Sub

    ' =========================================================================
    ' FUNCIONES AUXILIARES DE VALIDACIÓN Y CONTROL DE INTERFAZ
    ' =========================================================================

    Private Function ExisteEnListBox(ByVal textoBuscado As String) As Boolean
        For Each item As Object In ListBox1.Items
            If String.Equals(item.ToString().Trim(), textoBuscado, StringComparison.CurrentCultureIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function ExisteEnComboBox(ByVal textoBuscado As String) As Boolean
        For Each item As Object In ComboBox1.Items
            If String.Equals(item.ToString().Trim(), textoBuscado, StringComparison.CurrentCultureIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ActualizarEstado(ByVal mensaje As String)
        ToolStripStatusLabel1.Text = mensaje
    End Sub

    Private Sub MostrarError(ByVal mensajeUsuario As String, ByVal excepcion As Exception)
        ActualizarEstado("Error: " & mensajeUsuario)
        MessageBox.Show(mensajeUsuario & vbCrLf & vbCrLf &
                        "Detalle: " & excepcion.Message,
                        "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
