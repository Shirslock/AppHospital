<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitarTurno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.txtEspecialidadMedico = New System.Windows.Forms.TextBox()
        Me.txtNombreMedicoTurno = New System.Windows.Forms.TextBox()
        Me.txtMotivoTurno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaHoraTurno = New System.Windows.Forms.DateTimePicker()
        Me.btnSolicitarTurno = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(195, 141)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(200, 23)
        Me.txtNombrePaciente.TabIndex = 0
        '
        'txtEspecialidadMedico
        '
        Me.txtEspecialidadMedico.Location = New System.Drawing.Point(195, 235)
        Me.txtEspecialidadMedico.Name = "txtEspecialidadMedico"
        Me.txtEspecialidadMedico.Size = New System.Drawing.Size(200, 23)
        Me.txtEspecialidadMedico.TabIndex = 2
        '
        'txtNombreMedicoTurno
        '
        Me.txtNombreMedicoTurno.Location = New System.Drawing.Point(195, 286)
        Me.txtNombreMedicoTurno.Name = "txtNombreMedicoTurno"
        Me.txtNombreMedicoTurno.Size = New System.Drawing.Size(200, 23)
        Me.txtNombreMedicoTurno.TabIndex = 3
        '
        'txtMotivoTurno
        '
        Me.txtMotivoTurno.Location = New System.Drawing.Point(195, 340)
        Me.txtMotivoTurno.Name = "txtMotivoTurno"
        Me.txtMotivoTurno.Size = New System.Drawing.Size(200, 23)
        Me.txtMotivoTurno.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(51, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre del Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dia del turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Especialidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre del Medico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Motivo de Consulta"
        '
        'DateTimePickerFechaHoraTurno
        '
        Me.DateTimePickerFechaHoraTurno.Location = New System.Drawing.Point(195, 192)
        Me.DateTimePickerFechaHoraTurno.Name = "DateTimePickerFechaHoraTurno"
        Me.DateTimePickerFechaHoraTurno.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerFechaHoraTurno.TabIndex = 10
        '
        'btnSolicitarTurno
        '
        Me.btnSolicitarTurno.Location = New System.Drawing.Point(195, 387)
        Me.btnSolicitarTurno.Name = "btnSolicitarTurno"
        Me.btnSolicitarTurno.Size = New System.Drawing.Size(93, 31)
        Me.btnSolicitarTurno.TabIndex = 11
        Me.btnSolicitarTurno.Text = "&Solicitar Turno"
        Me.btnSolicitarTurno.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(1, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 43)
        Me.Panel1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(148, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SOLICITAR TURNO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(308, 387)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 31)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'SolicitarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(497, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSolicitarTurno)
        Me.Controls.Add(Me.DateTimePickerFechaHoraTurno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMotivoTurno)
        Me.Controls.Add(Me.txtNombreMedicoTurno)
        Me.Controls.Add(Me.txtEspecialidadMedico)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.Name = "SolicitarTurno"
        Me.Text = "SolicitarTurno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents txtEspecialidadMedico As TextBox
    Friend WithEvents txtNombreMedicoTurno As TextBox
    Friend WithEvents txtMotivoTurno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerFechaHoraTurno As DateTimePicker
    Friend WithEvents btnSolicitarTurno As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelar As Button
End Class
