Imports System.IO
Imports System.Text

Public Class SolicitarTurno

    '//Creo una lista para guardar mis datos//
    Private listaTurnosSolicitados As New List(Of TurnoSolicitado)

    '//Creo una funcion que me guarde los datos en la lista//
    Private Sub SolicitarTurno(nombrePaciente As String, fechaHoraTurno As DateTime, especialidadMedico As String, nombreMedico As String, motivoConsulta As String)
        Dim turnoSolicitado As New TurnoSolicitado()
        turnoSolicitado.NombrePaciente = nombrePaciente
        turnoSolicitado.FechaHoraTurno = fechaHoraTurno
        turnoSolicitado.EspecialidadMedico = especialidadMedico
        turnoSolicitado.NombreMedico = nombreMedico
        turnoSolicitado.MotivoConsulta = motivoConsulta

        listaTurnosSolicitados.Add(turnoSolicitado)

    End Sub

    '//Capturo los datos al hacer click en el button//
    Private Sub btnSolicitarTurno_Click(sender As Object, e As EventArgs) Handles btnSolicitarTurno.Click
        Dim nombrePaciente As String = txtNombrePaciente.Text
        Dim fechaHoraTurno As DateTime = DateTimePickerFechaHoraTurno.Value
        Dim especialidadMedico As String = txtEspecialidadMedico.Text
        Dim nombreMedico As String = txtNombreMedicoTurno.Text
        Dim motivoConsulta As String = txtMotivoTurno.Text


        SolicitarTurno(nombrePaciente, fechaHoraTurno, especialidadMedico, nombreMedico, motivoConsulta)

        Dim rutaArchivo As String = "D:\Programacion\AppHospital\AppHospital\turnoSolicitado.csv"


        GuardarTurnosSolicitadosEnCSV(rutaArchivo)

        txtNombrePaciente.Text = ""
        txtEspecialidadMedico.Text = ""
        txtNombreMedicoTurno.Text = ""
        txtMotivoTurno.Text = ""

    End Sub

    '//Funcion que me permite guardar los datos capturados en el CVS//
    Private Sub GuardarTurnosSolicitadosEnCSV(rutaArchivo As String)
        Try
            Dim sb As New StringBuilder()

            For Each turnoSolicitado As TurnoSolicitado In listaTurnosSolicitados
                Dim linea As String = $"{turnoSolicitado.NombrePaciente},{turnoSolicitado.FechaHoraTurno},{turnoSolicitado.EspecialidadMedico},{turnoSolicitado.NombreMedico},{turnoSolicitado.MotivoConsulta}"
                sb.AppendLine(linea)
            Next

            File.AppendAllText(rutaArchivo, sb.ToString(), Encoding.UTF8)
            MessageBox.Show("Turnos solicitados guardados correctamente. :D ", "Perfecto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar los turnos solicitados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class