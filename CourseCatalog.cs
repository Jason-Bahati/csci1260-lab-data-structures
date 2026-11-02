// CourseCatalog: looks up a course title by its code in one step.
//
// Part E. Build this class along with the Class 3 demo.
public class CourseCatalog
{
    // TODO: Part E. Declare one private field: a Dictionary<string, string>
    // that maps a course code to its title.

    // TODO: Part E. How many courses are in the catalog.
    public int Count => titles.Count;

    // Adds a course. Returns false, and changes nothing, when the code is
    // already there. Hint: one of the three ways to write does exactly this.
    public bool AddCourse(string code, string title)
    {
        // TODO: Part E, demo
        return titles.TryAdd(code, title);
    }

    // Returns the title for a code, or "(no such course)" when the code is
    // missing. Use TryGetValue, so the code is looked up only once.
    public string TitleFor(string code)
    {
        // TODO: Part E, demo
        if (titles.TryGetValue(code, out string title))
        {
            return title;
        }
        return "(no such course)";
    }

    private Dictionary<string, string> titles = new Dictionary<string, string>();
}
