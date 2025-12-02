using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class Add:PageModel
{   
    [BindProperty]
    public int Num1 { get; set; }
    [BindProperty]
    public int Num2 { get; set; }
    [BindProperty]
    public int? Result { get; set; }
public void OnPost()
    {
        Result = Num1 + Num2;
    }
}