
using SQLEntity;

using (SchoolContext db = new SchoolContext())
{
    Student studentToAdd = new Student();
    studentToAdd.Name = "Brandy";

    db.Students.Add(studentToAdd);
    db.SaveChanges();
}