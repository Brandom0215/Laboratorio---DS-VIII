<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Declaración de los controles solicitados
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeaderTitle As Label
    Friend WithEvents LabelHeaderSubtitle As Label

    'Panel Izquierdo - Vista Previa
    Friend WithEvents PanelLeftCard As Panel
    Friend WithEvents LabelCardLeftTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelSelectedTitle As Label
    Friend WithEvents Label1 As Label

    'Panel Derecho - Controles
    Friend WithEvents PanelRightCard As Panel
    Friend WithEvents LabelCardRightTitle As Label
    Friend WithEvents LabelInputDesc As Label
    Friend WithEvents TextBox1 As TextBox

    'Sección ListBox
    Friend WithEvents GroupListBox As Panel
    Friend WithEvents LabelListBoxHeader As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    'Sección ComboBox
    Friend WithEvents GroupComboBox As Panel
    Friend WithEvents LabelComboBoxHeader As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

    'Botón adicional de navegación (Menú)
    Friend WithEvents Button5 As Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()

        'Instanciación
        PanelHeader = New Panel()
        LabelHeaderTitle = New Label()
        LabelHeaderSubtitle = New Label()

        PanelLeftCard = New Panel()
        LabelCardLeftTitle = New Label()
        PictureBox1 = New PictureBox()
        LabelSelectedTitle = New Label()
        Label1 = New Label()

        PanelRightCard = New Panel()
        LabelCardRightTitle = New Label()
        LabelInputDesc = New Label()
        TextBox1 = New TextBox()

        GroupListBox = New Panel()
        LabelListBoxHeader = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()

        GroupComboBox = New Panel()
        LabelComboBoxHeader = New Label()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        Button4 = New Button()

        Button5 = New Button()

        PanelHeader.SuspendLayout()
        PanelLeftCard.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelRightCard.SuspendLayout()
        GroupListBox.SuspendLayout()
        GroupComboBox.SuspendLayout()
        SuspendLayout()

        '======================================================
        ' PanelHeader (Barra Superior Moderna)
        '======================================================
        PanelHeader.BackColor = Color.FromArgb(30, 41, 59) ' Slate 800
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Height = 70
        PanelHeader.Controls.Add(LabelHeaderTitle)
        PanelHeader.Controls.Add(LabelHeaderSubtitle)

        LabelHeaderTitle.Text = "CONTROLES COMBOBOX • LISTBOX • PICTUREBOX"
        LabelHeaderTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LabelHeaderTitle.ForeColor = Color.White
        LabelHeaderTitle.Location = New Point(24, 12)
        LabelHeaderTitle.AutoSize = True

        LabelHeaderSubtitle.Text = "Laboratorio ISA — Selección de recursos multimedia y gestión interactiva"
        LabelHeaderSubtitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        LabelHeaderSubtitle.ForeColor = Color.FromArgb(148, 163, 184) ' Slate 400
        LabelHeaderSubtitle.Location = New Point(25, 38)
        LabelHeaderSubtitle.AutoSize = True

        '======================================================
        ' PanelLeftCard (Tarjeta de Vista Previa y PictureBox)
        '======================================================
        PanelLeftCard.BackColor = Color.White
        PanelLeftCard.Location = New Point(24, 88)
        PanelLeftCard.Size = New Size(400, 490)
        PanelLeftCard.BorderStyle = BorderStyle.None

        LabelCardLeftTitle.Text = "VISUALIZACIÓN DE RECURSOS"
        LabelCardLeftTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelCardLeftTitle.ForeColor = Color.FromArgb(51, 65, 85) ' Slate 700
        LabelCardLeftTitle.Location = New Point(20, 18)
        LabelCardLeftTitle.AutoSize = True

        ' PictureBox1
        PictureBox1.BackColor = Color.FromArgb(241, 245, 249) ' Slate 100
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(20, 52)
        PictureBox1.Size = New Size(360, 310)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        ' Etiqueta descriptiva
        LabelSelectedTitle.Text = "Elemento Seleccionado:"
        LabelSelectedTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        LabelSelectedTitle.ForeColor = Color.FromArgb(100, 116, 139) ' Slate 500
        LabelSelectedTitle.Location = New Point(20, 380)
        LabelSelectedTitle.AutoSize = True

        ' Label1 (Nombre del elemento seleccionado en ListBox)
        Label1.Text = "(Ninguno)"
        Label1.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(37, 99, 235) ' Azul moderno
        Label1.Location = New Point(20, 402)
        Label1.Size = New Size(360, 30)
        Label1.TextAlign = ContentAlignment.MiddleLeft

        PanelLeftCard.Controls.Add(LabelCardLeftTitle)
        PanelLeftCard.Controls.Add(PictureBox1)
        PanelLeftCard.Controls.Add(LabelSelectedTitle)
        PanelLeftCard.Controls.Add(Label1)

        '======================================================
        ' PanelRightCard (Tarjeta de Controles de Entrada)
        '======================================================
        PanelRightCard.BackColor = Color.White
        PanelRightCard.Location = New Point(444, 88)
        PanelRightCard.Size = New Size(470, 490)
        PanelRightCard.BorderStyle = BorderStyle.None

        LabelCardRightTitle.Text = "PANEL DE CONTROL DE DATOS"
        LabelCardRightTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelCardRightTitle.ForeColor = Color.FromArgb(51, 65, 85)
        LabelCardRightTitle.Location = New Point(20, 18)
        LabelCardRightTitle.AutoSize = True

        ' Entrada de Texto (TextBox1)
        LabelInputDesc.Text = "Ingrese nuevo país / continente / elemento:"
        LabelInputDesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        LabelInputDesc.ForeColor = Color.FromArgb(71, 85, 105)
        LabelInputDesc.Location = New Point(20, 48)
        LabelInputDesc.AutoSize = True

        TextBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        TextBox1.Location = New Point(20, 70)
        TextBox1.Size = New Size(430, 29)
        TextBox1.BorderStyle = BorderStyle.FixedSingle

        '------------------------------------------------------
        ' Grupo ListBox
        '------------------------------------------------------
        GroupListBox.BackColor = Color.FromArgb(248, 250, 252)
        GroupListBox.BorderStyle = BorderStyle.FixedSingle
        GroupListBox.Location = New Point(20, 110)
        GroupListBox.Size = New Size(430, 175)

        LabelListBoxHeader.Text = "Lista de Elementos (ListBox)"
        LabelListBoxHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LabelListBoxHeader.ForeColor = Color.FromArgb(30, 41, 59)
        LabelListBoxHeader.Location = New Point(12, 10)
        LabelListBoxHeader.AutoSize = True

        ListBox1.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        ListBox1.ItemHeight = 22
        ListBox1.Location = New Point(12, 34)
        ListBox1.Size = New Size(260, 120)
        ListBox1.BorderStyle = BorderStyle.FixedSingle
        ' Elementos iniciales de muestra según la guía
        ListBox1.Items.AddRange(New Object() {"EUROPA", "OCEANIA", "ANTARTIDA", "AMERICA", "ASIA", "AFRICA"})

        ' Button1 (AGREGAR A LISTBOX)
        Button1.Text = "Agregar"
        Button1.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.FromArgb(37, 99, 235) ' Azul
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(285, 34)
        Button1.Size = New Size(130, 36)

        ' Button2 (ELIMINAR DE LISTBOX)
        Button2.Text = "Eliminar"
        Button2.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.BackColor = Color.FromArgb(220, 38, 38) ' Rojo
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(285, 78)
        Button2.Size = New Size(130, 36)

        GroupListBox.Controls.Add(LabelListBoxHeader)
        GroupListBox.Controls.Add(ListBox1)
        GroupListBox.Controls.Add(Button1)
        GroupListBox.Controls.Add(Button2)

        '------------------------------------------------------
        ' Grupo ComboBox
        '------------------------------------------------------
        GroupComboBox.BackColor = Color.FromArgb(248, 250, 252)
        GroupComboBox.BorderStyle = BorderStyle.FixedSingle
        GroupComboBox.Location = New Point(20, 298)
        GroupComboBox.Size = New Size(430, 130)

        LabelComboBoxHeader.Text = "Menú Desplegable (ComboBox)"
        LabelComboBoxHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LabelComboBoxHeader.ForeColor = Color.FromArgb(30, 41, 59)
        LabelComboBoxHeader.Location = New Point(12, 10)
        LabelComboBoxHeader.AutoSize = True

        ComboBox1.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Location = New Point(12, 38)
        ComboBox1.Size = New Size(260, 28)
        ComboBox1.FlatStyle = FlatStyle.Flat

        ' Button3 (AGREGAR A COMBOBOX)
        Button3.Text = "Agregar"
        Button3.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.BackColor = Color.FromArgb(16, 185, 129) ' Verde Esmeralda
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.Cursor = Cursors.Hand
        Button3.Location = New Point(285, 26)
        Button3.Size = New Size(130, 36)

        ' Button4 (ELIMINAR DE COMBOBOX)
        Button4.Text = "Eliminar"
        Button4.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.BackColor = Color.FromArgb(239, 68, 68) ' Rojo suave
        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 0
        Button4.Cursor = Cursors.Hand
        Button4.Location = New Point(285, 70)
        Button4.Size = New Size(130, 36)

        GroupComboBox.Controls.Add(LabelComboBoxHeader)
        GroupComboBox.Controls.Add(ComboBox1)
        GroupComboBox.Controls.Add(Button3)
        GroupComboBox.Controls.Add(Button4)

        ' Botón 5 (Volver al menú / Navegación según diapositiva 4)
        Button5.Text = "Volver al Menú"
        Button5.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        Button5.ForeColor = Color.FromArgb(71, 85, 105)
        Button5.BackColor = Color.FromArgb(241, 245, 249)
        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        Button5.Cursor = Cursors.Hand
        Button5.Location = New Point(20, 440)
        Button5.Size = New Size(430, 34)

        PanelRightCard.Controls.Add(LabelCardRightTitle)
        PanelRightCard.Controls.Add(LabelInputDesc)
        PanelRightCard.Controls.Add(TextBox1)
        PanelRightCard.Controls.Add(GroupListBox)
        PanelRightCard.Controls.Add(GroupComboBox)
        PanelRightCard.Controls.Add(Button5)

        '======================================================
        ' Configuración Principal del Formulario (Form1)
        '======================================================
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(241, 245, 249) ' Fondo general Slate 100 moderno
        ClientSize = New Size(940, 600)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "COMBOBOX - LISTBOX - PICTUREBOX"

        Controls.Add(PanelRightCard)
        Controls.Add(PanelLeftCard)
        Controls.Add(PanelHeader)

        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelLeftCard.ResumeLayout(False)
        PanelLeftCard.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupListBox.ResumeLayout(False)
        GroupListBox.PerformLayout()
        GroupComboBox.ResumeLayout(False)
        GroupComboBox.PerformLayout()
        PanelRightCard.ResumeLayout(False)
        PanelRightCard.PerformLayout()
        ResumeLayout(False)

    End Sub

End Class
