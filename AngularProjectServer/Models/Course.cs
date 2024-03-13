using serverProject.Controllers;

namespace AngularProjectServer.Models
{
    public enum Study
    {
        Online = 1,
        Offline,
        Hybrid
    }
    public class Course
    {
        public int id { get; set; }
        public int? lecturerId { get; set; }
        public Lecturer? lecturer { get; set; }
        public string? name { get; set; }
        public Category? category { get; set; }
        public int? countOfLessons { get; set; }
        public DateTime? start { get; set; }
        public List<string>? syllabus { get; set; }
        public Study? study { get; set; }
        public string? image { get; set; }

        public Course(int id, int? lecturerId, string? name, Category? category, int? countOfLessons, DateTime? start, List<string>? syllabus, Study? study, string? image)
        {
            this.id = id;
            this.lecturerId = lecturerId;
            this.name = name;
            this.category = category;
            this.countOfLessons = countOfLessons;
            this.start = start;
            this.syllabus = syllabus;
            this.study = study;
            this.image = image;
            lecturer = LecturerController.lecturers.Find(x => x.id == lecturerId);
        }
    }
}
