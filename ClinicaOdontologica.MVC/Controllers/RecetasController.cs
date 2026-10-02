using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class RecetasController : Controller
{
    // GET: RECETASS
    public ActionResult Index()    
    {
        var recetas = CRUD<Recetas>.GetAll();
        return View(recetas);
    }

    // GET: RECETASS/Details/5
    public ActionResult Details(int id)
    {
        var recetas = CRUD<Recetas>.GetById(id);
        if (id == null)
        {
            return NotFound();
        }
        return View(recetas);
    }

    // GET: RECETASS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: RECETASS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Recetas recetas)
    {
        try
        {
            CRUD<Recetas>.Create(recetas);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(recetas);
        }
    }

    // GET: RECETASS/Edit/5
    public ActionResult Edit(int id)
    {
        var recetas = CRUD<Recetas>.GetById(id);
        if (recetas == null)
        {
            return NotFound();
        }
        return View(recetas);
    }

    // POST: RECETASS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, Recetas recetas)
    {
        try
        {
            CRUD<Recetas>.Update(id, recetas);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(recetas);
        }
    }

    // GET: RECETASS/Delete/5
    public ActionResult Delete(int id)
    {
        var receta = CRUD<Recetas>.GetById(id);
        if (receta == null)
        {
            return NotFound();
        }
        return View(receta);
    }

    // POST: RECETASS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id,Recetas receta)
    {
        try
        {
            CRUD<Recetas>.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }

}
