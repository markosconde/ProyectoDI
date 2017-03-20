<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X600ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X700ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantallaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeControlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspañolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InglésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.encender = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.encender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaToolStripMenuItem, Me.IdiomaToolStripMenuItem1, Me.AyudaToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.ControlesToolStripMenuItem})
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        resources.ApplyResources(Me.IdiomaToolStripMenuItem, "IdiomaToolStripMenuItem")
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResoluciónToolStripMenuItem})
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        resources.ApplyResources(Me.CargarToolStripMenuItem, "CargarToolStripMenuItem")
        '
        'ResoluciónToolStripMenuItem
        '
        Me.ResoluciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X600ToolStripMenuItem, Me.X700ToolStripMenuItem, Me.PantallaCompletaToolStripMenuItem})
        Me.ResoluciónToolStripMenuItem.Name = "ResoluciónToolStripMenuItem"
        resources.ApplyResources(Me.ResoluciónToolStripMenuItem, "ResoluciónToolStripMenuItem")
        '
        'X600ToolStripMenuItem
        '
        Me.X600ToolStripMenuItem.Name = "X600ToolStripMenuItem"
        resources.ApplyResources(Me.X600ToolStripMenuItem, "X600ToolStripMenuItem")
        '
        'X700ToolStripMenuItem
        '
        Me.X700ToolStripMenuItem.Name = "X700ToolStripMenuItem"
        resources.ApplyResources(Me.X700ToolStripMenuItem, "X700ToolStripMenuItem")
        '
        'PantallaCompletaToolStripMenuItem
        '
        Me.PantallaCompletaToolStripMenuItem.Name = "PantallaCompletaToolStripMenuItem"
        resources.ApplyResources(Me.PantallaCompletaToolStripMenuItem, "PantallaCompletaToolStripMenuItem")
        '
        'ControlesToolStripMenuItem
        '
        Me.ControlesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeControlesToolStripMenuItem})
        Me.ControlesToolStripMenuItem.Name = "ControlesToolStripMenuItem"
        resources.ApplyResources(Me.ControlesToolStripMenuItem, "ControlesToolStripMenuItem")
        '
        'ListaDeControlesToolStripMenuItem
        '
        Me.ListaDeControlesToolStripMenuItem.Name = "ListaDeControlesToolStripMenuItem"
        resources.ApplyResources(Me.ListaDeControlesToolStripMenuItem, "ListaDeControlesToolStripMenuItem")
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspañolToolStripMenuItem, Me.InglésToolStripMenuItem})
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        resources.ApplyResources(Me.IdiomaToolStripMenuItem1, "IdiomaToolStripMenuItem1")
        '
        'EspañolToolStripMenuItem
        '
        Me.EspañolToolStripMenuItem.Name = "EspañolToolStripMenuItem"
        resources.ApplyResources(Me.EspañolToolStripMenuItem, "EspañolToolStripMenuItem")
        '
        'InglésToolStripMenuItem
        '
        Me.InglésToolStripMenuItem.Name = "InglésToolStripMenuItem"
        resources.ApplyResources(Me.InglésToolStripMenuItem, "InglésToolStripMenuItem")
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        '
        'encender
        '
        Me.encender.Image = Global.Proyecto.My.Resources.Imagenes.encender
        resources.ApplyResources(Me.encender, "encender")
        Me.encender.Name = "encender"
        Me.encender.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.encender)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.encender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResoluciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X600ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X700ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantallaCompletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeControlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EspañolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InglésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents encender As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
