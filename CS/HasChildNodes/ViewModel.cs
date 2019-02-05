using System.Collections.ObjectModel;

namespace HasChildNodes {

    public class BaseObject {
        public string Name { get; set; }
        public string Executor { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public bool HasChildNodes { get; set; }
        public override string ToString() { return Name; }
    }

    public class ProjectObject : BaseObject { }

    public class Task : BaseObject {
        public string State { get; set; }
    }

    public class ViewModel {
        public ObservableCollection<ProjectObject> DataItems { get; set; }

        public ViewModel() {
            DataItems = InitData();
        }

        ObservableCollection<ProjectObject> InitData() {
            ObservableCollection<ProjectObject> projects = new ObservableCollection<ProjectObject>();
            ProjectObject betaronProject = new ProjectObject() { Name = "Project: Betaron", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            ProjectObject stantoneProject = new ProjectObject() { Name = "Project: Stanton", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };

            InitBetaronProjectData(betaronProject);
            InitStantoneProjectData(stantoneProject);

            projects.Add(betaronProject);
            projects.Add(stantoneProject);

            return projects;
        }

        void InitBetaronProjectData(ProjectObject betaronProject) {
            betaronProject.Executor = "Mcfadyen Ball";
            Task Task11 = new Task() { Name = "Information Gathering", Executor = "Kaiden Savastano", Tasks = new ObservableCollection<Task>(), HasChildNodes = false };
            Task11.Tasks.Add(new Task() { Name = "Market research", Executor = "Carmine Then", State = "Completed", HasChildNodes = false });
            Task11.Tasks.Add(new Task() { Name = "Making specification", Executor = "Seto Kober", State = "In progress", HasChildNodes = false });

            Task Task12 = new Task() { Name = "Planning", Executor = "Manley Difrancesco", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            Task12.Tasks.Add(new Task() { Name = "Documentation", Executor = "Martez Gollin", State = "Not started", HasChildNodes = true });

            Task Task13 = new Task() { Name = "Design", Executor = "Clint Mary", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            Task13.Tasks.Add(new Task() { Name = "Design of a web pages", Executor = "Gasper Hartsell", State = "Not started", HasChildNodes = true });
            Task13.Tasks.Add(new Task() { Name = "Pages layout", Executor = "Shirish Huminski", State = "Not started", HasChildNodes = true });

            betaronProject.Tasks.Add(Task11);
            betaronProject.Tasks.Add(Task12);
            betaronProject.Tasks.Add(Task13);

        }

        void InitStantoneProjectData(ProjectObject stantoneProject) {
            stantoneProject.Executor = "Ruben Ackerman";
            Task Task21 = new Task() { Name = "Information Gathering", Executor = "Huyen Trinklein", Tasks = new ObservableCollection<Task>(), HasChildNodes = false };
            Task21.Tasks.Add(new Task() { Name = "Market research", Executor = "Tanner Crittendon", State = "Completed", HasChildNodes = false });
            Task21.Tasks.Add(new Task() { Name = "Making specification", Executor = "Carmine Then", State = "Completed", HasChildNodes = false });

            Task Task22 = new Task() { Name = "Planning", Executor = "Alfredo Sookoo", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            Task22.Tasks.Add(new Task() { Name = "Documentation", Executor = "Gorf Wobbe", State = "Completed", HasChildNodes = true });

            Task Task23 = new Task() { Name = "Design", Executor = "Saphire Plump", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            Task23.Tasks.Add(new Task() { Name = "Design of a web pages", Executor = "Dominic Minden", State = "In progress", HasChildNodes = true });
            Task23.Tasks.Add(new Task() { Name = "Pages layout", Executor = "Pinkerton Trezise", State = "In progress", HasChildNodes = true });

            Task Task24 = new Task() { Name = "Development", Executor = "Lauren Partain", Tasks = new ObservableCollection<Task>(), HasChildNodes = true };
            Task24.Tasks.Add(new Task() { Name = "Design", Executor = "Delilah Beamer", State = "In progress", HasChildNodes = true });
            Task24.Tasks.Add(new Task() { Name = "Coding", Executor = "Dunaway Dupriest", State = "Not started", HasChildNodes = true });

            stantoneProject.Tasks.Add(Task21);
            stantoneProject.Tasks.Add(Task22);
            stantoneProject.Tasks.Add(Task23);
            stantoneProject.Tasks.Add(Task24);
        }
    }
}