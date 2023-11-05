using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

public class FormController: Controller
{
    [HttpGet]
    public IActionResult Form(Data data)
    {
        if (ModelState.IsValid)
        {
            return View("Output", data);
        }
        else return View();
    }

    public IActionResult Wynik(Data data)
    {
        return View(data);
    }
}