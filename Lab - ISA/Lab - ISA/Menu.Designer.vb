<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.LabelSubtitle = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.ButtonOpenModule = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.PanelCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LabelSubtitle)
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(560, 75)
        Me.PanelHeader.TabIndex = 0
        '
        'LabelSubtitle
        '
        Me.LabelSubtitle.AutoSize = True
        Me.LabelSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LabelSubtitle.Location = New System.Drawing.Point(24, 42)
        Me.LabelSubtitle.Name = "LabelSubtitle"
        Me.LabelSubtitle.Size = New System.Drawing.Size(262, 15)
        Me.LabelSubtitle.TabIndex = 1
        Me.LabelSubtitle.Text = "Prof. Jorge Marín • Laboratorio de Software VIII"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(22, 14)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(182, 25)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "MENÚ PRINCIPAL"
        '
        'PanelCard
        '
        Me.PanelCard.BackColor = System.Drawing.Color.White
        Me.PanelCard.Controls.Add(Me.LabelInfo)
        Me.PanelCard.Controls.Add(Me.LabelSubject)
        Me.PanelCard.Controls.Add(Me.ButtonOpenModule)
        Me.PanelCard.Controls.Add(Me.ButtonExit)
        Me.PanelCard.Location = New System.Drawing.Point(30, 95)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(500, 240)
        Me.PanelCard.TabIndex = 1
        '
        'LabelInfo
        '
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LabelInfo.Location = New System.Drawing.Point(25, 52)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(450, 48)
        Me.LabelInfo.TabIndex = 1
        Me.LabelInfo.Text = "Práctica de manipulación de listas, combos y despliegue interactivo de recursos multimedia con validación y navegación robusta."
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LabelSubject.Location = New System.Drawing.Point(24, 22)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(352, 20)
        Me.LabelSubject.TabIndex = 0
        Me.LabelSubject.Text = "Módulo 1: ComboBox • ListBox • PictureBox"
        '
        'ButtonOpenModule
        '
        Me.ButtonOpenModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ButtonOpenModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOpenModule.FlatAppearance.BorderSize = 0
        Me.ButtonOpenModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenModule.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOpenModule.ForeColor = System.Drawing.Color.White
        Me.ButtonOpenModule.Location = New System.Drawing.Point(28, 120)
        Me.ButtonOpenModule.Name = "ButtonOpenModule"
        Me.ButtonOpenModule.Size = New System.Drawing.Size(444, 42)
        Me.ButtonOpenModule.TabIndex = 2
        Me.ButtonOpenModule.Text = "Abrir Práctica de Controles"
        Me.ButtonOpenModule.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonExit.Location = New System.Drawing.Point(28, 174)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(444, 38)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Cerrar Menú"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 365)
        Me.Controls.Add(Me.PanelCard)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal - Laboratorio ISA"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelCard.ResumeLayout(False)
        Me.PanelCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelSubtitle As System.Windows.Forms.Label
    Friend WithEvents PanelCard As System.Windows.Forms.Panel
    Friend WithEvents LabelSubject As System.Windows.Forms.Label
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenModule As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
End Class
