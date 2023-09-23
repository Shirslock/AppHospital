<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoMedico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreMedico = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtHorario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardarMedico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Especialidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horario:"
        '
        'txtNombreMedico
        '
        Me.txtNombreMedico.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombreMedico.Location = New System.Drawing.Point(126, 126)
        Me.txtNombreMedico.Name = "txtNombreMedico"
        Me.txtNombreMedico.Size = New System.Drawing.Size(155, 23)
        Me.txtNombreMedico.TabIndex = 3
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.BackColor = System.Drawing.SystemColors.Info
        Me.txtEspecialidad.Location = New System.Drawing.Point(126, 177)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(155, 23)
        Me.txtEspecialidad.TabIndex = 4
        '
        'txtHorario
        '
        Me.txtHorario.BackColor = System.Drawing.SystemColors.Info
        Me.txtHorario.Location = New System.Drawing.Point(126, 239)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(155, 23)
        Me.txtHorario.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(111, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NUEVO MEDICO"
        '
        'btnGuardarMedico
        '
        Me.btnGuardarMedico.Location = New System.Drawing.Point(145, 299)
        Me.btnGuardarMedico.Name = "btnGuardarMedico"
        Me.btnGuardarMedico.Size = New System.Drawing.Size(106, 35)
        Me.btnGuardarMedico.TabIndex = 7
        Me.btnGuardarMedico.Text = "Guardar Medico"
        Me.btnGuardarMedico.UseVisualStyleBackColor = True
        '
        'NuevoMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(416, 450)
        Me.Controls.Add(Me.btnGuardarMedico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.txtEspecialidad)
        Me.Controls.Add(Me.txtNombreMedico)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoMedico"
        Me.Text = "NuevoMedico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreMedico As TextBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtHorario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardarMedico As Button
End Class
