Imports System.IO
Imports System.Text

Public Class NuevoPaciente
    '//FUNCION PARA GUARDAR A LOS PACIENTES EN EL ARCHIVO CSV//
    Private Sub GuardarPacienteEnCSV(paciente As Paciente, rutaArchivo As String)
        Try
            Dim linea As String = $"{paciente.Nombre},{paciente.Apellido},{paciente.Telefono},{paciente.CorreoElectronico}"
            File.AppendAllText(rutaArchivo, linea & Environment.NewLine, Encoding.UTF8)
            MessageBox.Show("Datos del paciente guardados correctamente. :D ", "Perfecto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar los datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//EVENTO PARA GUARDAR A LOS PACIENTES AL HACER CLICK//
    Private Sub btnGuardarPaciente_Click(sender As Object, e As EventArgs) Handles btnGuardarPaciente.Click
        Dim paciente As New Paciente()
        paciente.Nombre = txtNombre.Text
        paciente.Apellido = txtApellido.Text
        paciente.Telefono = txtTelefono.Text
        paciente.CorreoElectronico = txtCorreoElectronico.Text


        Dim rutaArchivo As String = "D:\Programacion\AppHospital\AppHospital\Paciente.csv"

        GuardarPacienteEnCSV(paciente, rutaArchivo)

        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""

    End Sub
End Class