Imports System.IO
Imports System.Text

Public Class NuevoMedico
    '//Creo la funcion para guardar los datos en el csv//
    Private Sub GuardarMedicoEnCSV(medico As Medico, rutaArchivo As String)
        Try
            Dim linea As String = $"{medico.Nombre},{medico.Especialidad},{medico.HorarioDisponible}"
            File.AppendAllText(rutaArchivo, linea & Environment.NewLine, Encoding.UTF8)
            MessageBox.Show("Datos del médico guardados correctamente. :D", "Perfecto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar los datos del médico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '//Creo el evento para que al hacer click se guarden los datos//
    Private Sub btnGuardarMedico_Click(sender As Object, e As EventArgs) Handles btnGuardarMedico.Click
        Dim medico As New Medico()
        medico.Nombre = txtNombreMedico.Text
        medico.Especialidad = txtEspecialidad.Text
        medico.HorarioDisponible = txtHorario.Text

        Dim rutaArchivo As String = "D:\Programacion\AppHospital\AppHospital\Medico.csv"

        GuardarMedicoEnCSV(medico, rutaArchivo)

        '//Con esto limpio los campos//
        txtNombreMedico.Text = ""
        txtEspecialidad.Text = ""
        txtHorario.Text = ""
    End Sub
End Class