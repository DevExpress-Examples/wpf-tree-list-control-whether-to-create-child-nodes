Imports System.Collections.ObjectModel

Namespace HasChildNodes

    Public Class BaseObject

        Public Property Name As String

        Public Property Executor As String

        Public Property Tasks As ObservableCollection(Of Task)

        Public Property HasChildNodes As Boolean

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class ProjectObject
        Inherits BaseObject

    End Class

    Public Class Task
        Inherits BaseObject

        Public Property State As String
    End Class

    Public Class ViewModel

        Public Property DataItems As ObservableCollection(Of ProjectObject)

        Public Sub New()
            DataItems = InitData()
        End Sub

        Private Function InitData() As ObservableCollection(Of ProjectObject)
            Dim projects As ObservableCollection(Of ProjectObject) = New ObservableCollection(Of ProjectObject)()
            Dim betaronProject As ProjectObject = New ProjectObject() With {.Name = "Project: Betaron", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Dim stantoneProject As ProjectObject = New ProjectObject() With {.Name = "Project: Stanton", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            InitBetaronProjectData(betaronProject)
            InitStantoneProjectData(stantoneProject)
            projects.Add(betaronProject)
            projects.Add(stantoneProject)
            Return projects
        End Function

        Private Sub InitBetaronProjectData(ByVal betaronProject As ProjectObject)
            betaronProject.Executor = "Mcfadyen Ball"
            Dim Task11 As Task = New Task() With {.Name = "Information Gathering", .Executor = "Kaiden Savastano", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = False}
            Task11.Tasks.Add(New Task() With {.Name = "Market research", .Executor = "Carmine Then", .State = "Completed", .HasChildNodes = False})
            Task11.Tasks.Add(New Task() With {.Name = "Making specification", .Executor = "Seto Kober", .State = "In progress", .HasChildNodes = False})
            Dim Task12 As Task = New Task() With {.Name = "Planning", .Executor = "Manley Difrancesco", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Task12.Tasks.Add(New Task() With {.Name = "Documentation", .Executor = "Martez Gollin", .State = "Not started", .HasChildNodes = True})
            Dim Task13 As Task = New Task() With {.Name = "Design", .Executor = "Clint Mary", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Task13.Tasks.Add(New Task() With {.Name = "Design of a web pages", .Executor = "Gasper Hartsell", .State = "Not started", .HasChildNodes = True})
            Task13.Tasks.Add(New Task() With {.Name = "Pages layout", .Executor = "Shirish Huminski", .State = "Not started", .HasChildNodes = True})
            betaronProject.Tasks.Add(Task11)
            betaronProject.Tasks.Add(Task12)
            betaronProject.Tasks.Add(Task13)
        End Sub

        Private Sub InitStantoneProjectData(ByVal stantoneProject As ProjectObject)
            stantoneProject.Executor = "Ruben Ackerman"
            Dim Task21 As Task = New Task() With {.Name = "Information Gathering", .Executor = "Huyen Trinklein", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = False}
            Task21.Tasks.Add(New Task() With {.Name = "Market research", .Executor = "Tanner Crittendon", .State = "Completed", .HasChildNodes = False})
            Task21.Tasks.Add(New Task() With {.Name = "Making specification", .Executor = "Carmine Then", .State = "Completed", .HasChildNodes = False})
            Dim Task22 As Task = New Task() With {.Name = "Planning", .Executor = "Alfredo Sookoo", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Task22.Tasks.Add(New Task() With {.Name = "Documentation", .Executor = "Gorf Wobbe", .State = "Completed", .HasChildNodes = True})
            Dim Task23 As Task = New Task() With {.Name = "Design", .Executor = "Saphire Plump", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Task23.Tasks.Add(New Task() With {.Name = "Design of a web pages", .Executor = "Dominic Minden", .State = "In progress", .HasChildNodes = True})
            Task23.Tasks.Add(New Task() With {.Name = "Pages layout", .Executor = "Pinkerton Trezise", .State = "In progress", .HasChildNodes = True})
            Dim Task24 As Task = New Task() With {.Name = "Development", .Executor = "Lauren Partain", .Tasks = New ObservableCollection(Of Task)(), .HasChildNodes = True}
            Task24.Tasks.Add(New Task() With {.Name = "Design", .Executor = "Delilah Beamer", .State = "In progress", .HasChildNodes = True})
            Task24.Tasks.Add(New Task() With {.Name = "Coding", .Executor = "Dunaway Dupriest", .State = "Not started", .HasChildNodes = True})
            stantoneProject.Tasks.Add(Task21)
            stantoneProject.Tasks.Add(Task22)
            stantoneProject.Tasks.Add(Task23)
            stantoneProject.Tasks.Add(Task24)
        End Sub
    End Class
End Namespace
