<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.MedicoToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPacienteToolStripMenuItem, Me.SolicitarTurnoToolStripMenuItem})
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.PacienteToolStripMenuItem.Text = "&Paciente"
        '
        'NuevoPacienteToolStripMenuItem
        '
        Me.NuevoPacienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NuevoPacienteToolStripMenuItem.Name = "NuevoPacienteToolStripMenuItem"
        Me.NuevoPacienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoPacienteToolStripMenuItem.Text = "&Nuevo Paciente"
        '
        'SolicitarTurnoToolStripMenuItem
        '
        Me.SolicitarTurnoToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SolicitarTurnoToolStripMenuItem.Name = "SolicitarTurnoToolStripMenuItem"
        Me.SolicitarTurnoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SolicitarTurnoToolStripMenuItem.Text = "&Solicitar Turno"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoMedicoToolStripMenuItem, Me.VerAgendaToolStripMenuItem})
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MedicoToolStripMenuItem.Text = "&Medico"
        '
        'NuevoMedicoToolStripMenuItem
        '
        Me.NuevoMedicoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NuevoMedicoToolStripMenuItem.Name = "NuevoMedicoToolStripMenuItem"
        Me.NuevoMedicoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoMedicoToolStripMenuItem.Text = "&Nuevo Medico"
        '
        'VerAgendaToolStripMenuItem
        '
        Me.VerAgendaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.VerAgendaToolStripMenuItem.Name = "VerAgendaToolStripMenuItem"
        Me.VerAgendaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerAgendaToolStripMenuItem.Text = "&Ver Agenda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoMedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
