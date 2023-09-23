Imports System.IO
Imports System.Text


Public Class Agenda

    '//Creo una lista para ver los turnos solicitados//
    Private listaDeTurnosSolicitados As New List(Of TurnoSolicitado)

    '//Funcion que lee los datos de la lista y los guarda//
    Private Sub LeerTurnosSolicitadosDesdeCSV(rutaArchivo As String)
        Try
            Dim lineas As String() = File.ReadAllLines(rutaArchivo, Encoding.UTF8)

            For Each linea As String In lineas
                Dim datos As String() = linea.Split(","c)

                If datos.Length = 5 Then
                    Dim turno As New TurnoSolicitado()
                    turno.NombrePaciente = datos(0)
                    turno.FechaHoraTurno = DateTime.Parse(datos(1))
                    turno.EspecialidadMedico = datos(2)
                    turno.NombreMedico = datos(3)
                    turno.MotivoConsulta = datos(4)

                    listaDeTurnosSolicitados.Add(turno)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '//Funcion que permite visualizar el GridView//
    Private Sub MostrarAgendaMedico(nombreMedico As String)
        Dim agendaMedico As List(Of TurnoSolicitado) = listaDeTurnosSolicitados.Where(Function(turno) turno.NombreMedico = nombreMedico).ToList()

        '// Asigno la lista de turnos del médico al DataGridView para mostrar la agenda.
        DataGridView1.DataSource = agendaMedico
    End Sub

    '//ComboBox que me permite visualizar el nombre de los medicos con turnos agendados//
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMedicos.SelectedIndexChanged
        Dim nombreMedico As String = ComboBoxMedicos.SelectedItem.ToString()
        MostrarAgendaMedico(nombreMedico)
    End Sub

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaArchivo As String = "D:\Programacion\AppHospital\AppHospital\turnoSolicitado.csv"
        LeerTurnosSolicitadosDesdeCSV(rutaArchivo)

        '// Lleno el ComboBox con los nombres de los médicos.//
        ComboBoxMedicos.Items.AddRange(listaDeTurnosSolicitados.Select(Function(turno) turno.NombreMedico).Distinct().ToArray())
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class