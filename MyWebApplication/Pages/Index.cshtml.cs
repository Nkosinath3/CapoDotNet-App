using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using MyWebApplication.Models;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? NewTask { get; set; }

   public static List<TaskItem> Tasks = new List<TaskItem>();

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(NewTask))
        {
            
Tasks.Add(new TaskItem
{
    Name = NewTask,
    IsCompleted = false
});

        }
    }

    public void OnPostDelete(int index)
    {
        if (index >= 0 && index < Tasks.Count)
        {
            Tasks.RemoveAt(index);
        }
    }

    public void OnPostClear()
    {
        Tasks.Clear();
    }

    public void OnPostToggle(int index)
{
    if (index >= 0 && index < Tasks.Count)
    {
        Tasks[index].IsCompleted = !Tasks[index].IsCompleted;
    }
}
}
