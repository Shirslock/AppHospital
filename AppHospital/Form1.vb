Imports System.IO
Imports System.Text

Public Class Form1
    '//CREO LAS RELACIONES DE LOS FORMULARIOS//

    Private Sub NuevoPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPacienteToolStripMenuItem.Click
        Dim nuevoPaciente As New NuevoPaciente
        nuevoPaciente.ShowDialog()
    End Sub

    Private Sub SolicitarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarTurnoToolStripMenuItem.Click
        Dim solicitarTurno As New SolicitarTurno
        solicitarTurno.ShowDialog()
    End Sub

    Private Sub NuevoMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMedicoToolStripMenuItem.Click
        Dim nuevoMedico As New NuevoMedico
        nuevoMedico.ShowDialog()
    End Sub

    Private Sub VerAgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAgendaToolStripMenuItem.Click
        Dim agenda As New Agenda
        agenda.ShowDialog()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MessageBox.Show("Bienvenidos a la app del hospital")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("App creada por Gil Cristian desarrollada para el final de Programacion II")
    End Sub
End Class
