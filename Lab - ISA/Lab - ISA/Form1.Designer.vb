<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.ButtonSelectFolder = New System.Windows.Forms.Button()
        Me.LabelHeaderSubtitle = New System.Windows.Forms.Label()
        Me.LabelHeaderTitle = New System.Windows.Forms.Label()
        Me.PanelLeftCard = New System.Windows.Forms.Panel()
        Me.LabelImagePath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSelectedTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelCardLeftTitle = New System.Windows.Forms.Label()
        Me.PanelRightCard = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.GroupComboBox = New System.Windows.Forms.Panel()
        Me.ButtonTransferToList = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelComboBoxHeader = New System.Windows.Forms.Label()
        Me.GroupListBox = New System.Windows.Forms.Panel()
        Me.ButtonTransferToCombo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelListBoxHeader = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelInputDesc = New System.Windows.Forms.Label()
        Me.LabelCardRightTitle = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PanelHeader.SuspendLayout()
        Me.PanelLeftCard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRightCard.SuspendLayout()
        Me.GroupComboBox.SuspendLayout()
        Me.GroupListBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.ButtonSelectFolder)
        Me.PanelHeader.Controls.Add(Me.LabelHeaderSubtitle)
        Me.PanelHeader.Controls.Add(Me.LabelHeaderTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(984, 75)
        Me.PanelHeader.TabIndex = 0
        '
        'ButtonSelectFolder
        '
        Me.ButtonSelectFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ButtonSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectFolder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSelectFolder.ForeColor = System.Drawing.Color.White
        Me.ButtonSelectFolder.Location = New System.Drawing.Point(744, 18)
        Me.ButtonSelectFolder.Name = "ButtonSelectFolder"
        Me.ButtonSelectFolder.Size = New System.Drawing.Size(216, 38)
        Me.ButtonSelectFolder.TabIndex = 2
        Me.ButtonSelectFolder.Text = "📁 Carpeta de Recursos..."
        Me.ButtonSelectFolder.UseVisualStyleBackColor = False
        '
        'LabelHeaderSubtitle
        '
        Me.LabelHeaderSubtitle.AutoSize = True
        Me.LabelHeaderSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LabelHeaderSubtitle.Location = New System.Drawing.Point(24, 42)
        Me.LabelHeaderSubtitle.Name = "LabelHeaderSubtitle"
        Me.LabelHeaderSubtitle.Size = New System.Drawing.Size(378, 15)
        Me.LabelHeaderSubtitle.TabIndex = 1
        Me.LabelHeaderSubtitle.Text = "Laboratorio ISA — Selección de recursos e interacción ListBox y ComboBox"
        '
        'LabelHeaderTitle
        '
        Me.LabelHeaderTitle.AutoSize = True
        Me.LabelHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.LabelHeaderTitle.Location = New System.Drawing.Point(22, 14)
        Me.LabelHeaderTitle.Name = "LabelHeaderTitle"
        Me.LabelHeaderTitle.Size = New System.Drawing.Size(434, 23)
        Me.LabelHeaderTitle.TabIndex = 0
        Me.LabelHeaderTitle.Text = "CONTROLES COMBOBOX • LISTBOX • PICTUREBOX"
        '
        'PanelLeftCard
        '
        Me.PanelLeftCard.BackColor = System.Drawing.Color.White
        Me.PanelLeftCard.Controls.Add(Me.LabelImagePath)
        Me.PanelLeftCard.Controls.Add(Me.Label1)
        Me.PanelLeftCard.Controls.Add(Me.LabelSelectedTitle)
        Me.PanelLeftCard.Controls.Add(Me.PictureBox1)
        Me.PanelLeftCard.Controls.Add(Me.LabelCardLeftTitle)
        Me.PanelLeftCard.Location = New System.Drawing.Point(24, 90)
        Me.PanelLeftCard.Name = "PanelLeftCard"
        Me.PanelLeftCard.Size = New System.Drawing.Size(420, 500)
        Me.PanelLeftCard.TabIndex = 1
        '
        'LabelImagePath
        '
        Me.LabelImagePath.AutoEllipsis = True
        Me.LabelImagePath.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.LabelImagePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelImagePath.Location = New System.Drawing.Point(20, 445)
        Me.LabelImagePath.Name = "LabelImagePath"
        Me.LabelImagePath.Size = New System.Drawing.Size(380, 40)
        Me.LabelImagePath.TabIndex = 4
        Me.LabelImagePath.Text = "Origen: Carpeta de recursos del sistema"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(Ninguno)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSelectedTitle
        '
        Me.LabelSelectedTitle.AutoSize = True
        Me.LabelSelectedTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSelectedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LabelSelectedTitle.Location = New System.Drawing.Point(20, 385)
        Me.LabelSelectedTitle.Name = "LabelSelectedTitle"
        Me.LabelSelectedTitle.Size = New System.Drawing.Size(189, 15)
        Me.LabelSelectedTitle.TabIndex = 2
        Me.LabelSelectedTitle.Text = "ELEMENTO ACTIVO (ListBox1):"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(20, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelCardLeftTitle
        '
        Me.LabelCardLeftTitle.AutoSize = True
        Me.LabelCardLeftTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelCardLeftTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LabelCardLeftTitle.Location = New System.Drawing.Point(18, 18)
        Me.LabelCardLeftTitle.Name = "LabelCardLeftTitle"
        Me.LabelCardLeftTitle.Size = New System.Drawing.Size(201, 19)
        Me.LabelCardLeftTitle.TabIndex = 0
        Me.LabelCardLeftTitle.Text = "VISUALIZACIÓN DE RECURSOS"
        '
        'PanelRightCard
        '
        Me.PanelRightCard.BackColor = System.Drawing.Color.White
        Me.PanelRightCard.Controls.Add(Me.Button5)
        Me.PanelRightCard.Controls.Add(Me.ButtonReset)
        Me.PanelRightCard.Controls.Add(Me.GroupComboBox)
        Me.PanelRightCard.Controls.Add(Me.GroupListBox)
        Me.PanelRightCard.Controls.Add(Me.TextBox1)
        Me.PanelRightCard.Controls.Add(Me.LabelInputDesc)
        Me.PanelRightCard.Controls.Add(Me.LabelCardRightTitle)
        Me.PanelRightCard.Location = New System.Drawing.Point(464, 90)
        Me.PanelRightCard.Name = "PanelRightCard"
        Me.PanelRightCard.Size = New System.Drawing.Size(496, 500)
        Me.PanelRightCard.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(252, 445)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(224, 38)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "📋 Menú Principal"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonReset.Location = New System.Drawing.Point(20, 445)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(218, 38)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "🔄 Reiniciar Lista"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'GroupComboBox
        '
        Me.GroupComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GroupComboBox.Controls.Add(Me.ButtonTransferToList)
        Me.GroupComboBox.Controls.Add(Me.Button4)
        Me.GroupComboBox.Controls.Add(Me.Button3)
        Me.GroupComboBox.Controls.Add(Me.ComboBox1)
        Me.GroupComboBox.Controls.Add(Me.LabelComboBoxHeader)
        Me.GroupComboBox.Location = New System.Drawing.Point(20, 285)
        Me.GroupComboBox.Name = "GroupComboBox"
        Me.GroupComboBox.Size = New System.Drawing.Size(456, 145)
        Me.GroupComboBox.TabIndex = 4
        '
        'ButtonTransferToList
        '
        Me.ButtonTransferToList.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonTransferToList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTransferToList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ButtonTransferToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTransferToList.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTransferToList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonTransferToList.Location = New System.Drawing.Point(14, 85)
        Me.ButtonTransferToList.Name = "ButtonTransferToList"
        Me.ButtonTransferToList.Size = New System.Drawing.Size(264, 38)
        Me.ButtonTransferToList.TabIndex = 4
        Me.ButtonTransferToList.Text = "⬅ Recibir en ListBox desde Combo"
        Me.ButtonTransferToList.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(298, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Eliminar de Combo"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(298, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Agregar a Combo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(264, 25)
        Me.ComboBox1.TabIndex = 1
        '
        'LabelComboBoxHeader
        '
        Me.LabelComboBoxHeader.AutoSize = True
        Me.LabelComboBoxHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelComboBoxHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LabelComboBoxHeader.Location = New System.Drawing.Point(12, 14)
        Me.LabelComboBoxHeader.Name = "LabelComboBoxHeader"
        Me.LabelComboBoxHeader.Size = New System.Drawing.Size(183, 15)
        Me.LabelComboBoxHeader.TabIndex = 0
        Me.LabelComboBoxHeader.Text = "Menú Desplegable (ComboBox1)"
        '
        'GroupListBox
        '
        Me.GroupListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GroupListBox.Controls.Add(Me.ButtonTransferToCombo)
        Me.GroupListBox.Controls.Add(Me.Button2)
        Me.GroupListBox.Controls.Add(Me.Button1)
        Me.GroupListBox.Controls.Add(Me.ListBox1)
        Me.GroupListBox.Controls.Add(Me.LabelListBoxHeader)
        Me.GroupListBox.Location = New System.Drawing.Point(20, 105)
        Me.GroupListBox.Name = "GroupListBox"
        Me.GroupListBox.Size = New System.Drawing.Size(456, 170)
        Me.GroupListBox.TabIndex = 3
        '
        'ButtonTransferToCombo
        '
        Me.ButtonTransferToCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonTransferToCombo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTransferToCombo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ButtonTransferToCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTransferToCombo.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTransferToCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonTransferToCombo.Location = New System.Drawing.Point(298, 118)
        Me.ButtonTransferToCombo.Name = "ButtonTransferToCombo"
        Me.ButtonTransferToCombo.Size = New System.Drawing.Size(142, 36)
        Me.ButtonTransferToCombo.TabIndex = 4
        Me.ButtonTransferToCombo.Text = "Pasar a Combo ➔"
        Me.ButtonTransferToCombo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(298, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar de Lista"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(298, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar a Lista"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Items.AddRange(New Object() {"EUROPA", "OCEANIA", "ANTARTIDA", "AMERICA", "ASIA", "AFRICA"})
        Me.ListBox1.Location = New System.Drawing.Point(14, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(264, 121)
        Me.ListBox1.TabIndex = 1
        '
        'LabelListBoxHeader
        '
        Me.LabelListBoxHeader.AutoSize = True
        Me.LabelListBoxHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelListBoxHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LabelListBoxHeader.Location = New System.Drawing.Point(12, 10)
        Me.LabelListBoxHeader.Name = "LabelListBoxHeader"
        Me.LabelListBoxHeader.Size = New System.Drawing.Size(150, 15)
        Me.LabelListBoxHeader.TabIndex = 0
        Me.LabelListBoxHeader.Text = "Lista Principal (ListBox1)"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(20, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 25)
        Me.TextBox1.TabIndex = 2
        '
        'LabelInputDesc
        '
        Me.LabelInputDesc.AutoSize = True
        Me.LabelInputDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInputDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LabelInputDesc.Location = New System.Drawing.Point(18, 48)
        Me.LabelInputDesc.Name = "LabelInputDesc"
        Me.LabelInputDesc.Size = New System.Drawing.Size(246, 15)
        Me.LabelInputDesc.TabIndex = 1
        Me.LabelInputDesc.Text = "Ingrese nuevo continente / país / elemento:"
        '
        'LabelCardRightTitle
        '
        Me.LabelCardRightTitle.AutoSize = True
        Me.LabelCardRightTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelCardRightTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LabelCardRightTitle.Location = New System.Drawing.Point(18, 18)
        Me.LabelCardRightTitle.Name = "LabelCardRightTitle"
        Me.LabelCardRightTitle.Size = New System.Drawing.Size(217, 19)
        Me.LabelCardRightTitle.TabIndex = 0
        Me.LabelCardRightTitle.Text = "GESTIÓN Y CONTROL DE DATOS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 609)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 3
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(350, 17)
        Me.ToolStripStatusLabel1.Text = "Listo. Seleccione un continente o ingrese un nuevo elemento."
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Seleccione la carpeta que contiene las imágenes de los recursos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 631)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelRightCard)
        Me.Controls.Add(Me.PanelLeftCard)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMBOBOX - LISTBOX - PICTUREBOX"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelLeftCard.ResumeLayout(False)
        Me.PanelLeftCard.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRightCard.ResumeLayout(False)
        Me.PanelRightCard.PerformLayout()
        Me.GroupComboBox.ResumeLayout(False)
        Me.GroupComboBox.PerformLayout()
        Me.GroupListBox.ResumeLayout(False)
        Me.GroupListBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LabelHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents LabelHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectFolder As System.Windows.Forms.Button
    Friend WithEvents PanelLeftCard As System.Windows.Forms.Panel
    Friend WithEvents LabelCardLeftTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelSelectedTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelImagePath As System.Windows.Forms.Label
    Friend WithEvents PanelRightCard As System.Windows.Forms.Panel
    Friend WithEvents LabelCardRightTitle As System.Windows.Forms.Label
    Friend WithEvents LabelInputDesc As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupListBox As System.Windows.Forms.Panel
    Friend WithEvents LabelListBoxHeader As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ButtonTransferToCombo As System.Windows.Forms.Button
    Friend WithEvents GroupComboBox As System.Windows.Forms.Panel
    Friend WithEvents LabelComboBoxHeader As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ButtonTransferToList As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
