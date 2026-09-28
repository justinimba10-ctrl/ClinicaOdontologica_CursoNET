using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;

public class OdontologosController : Controller
{
   // GET: ODONTOLOGOS
    public ActionResult Index()    
    {
        var odontologos = CRUD<Odontologo>.GetAll();
        return View(odontologos);
    }

    // GET: ODONTOLOGOS/Details/5
    public ActionResult Details(int idodontologo)
    {
        var odontologos = CRUD<Odontologo>.GetById(idodontologo);
        if (idodontologo == null)
        {
            return NotFound();
        }
        return View(odontologos);
    }

    // GET: ODONTOLOGOS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ODONTOLOGOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create( Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Create(odontologo);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(odontologo);
        }
    }

    // GET: ODONTOLOGOS/Edit/5
    public ActionResult Edit(int idodontologo)
    {
        var odontologos = CRUD<Odontologo>.GetById(idodontologo);
        if (odontologos == null)
        {
            return NotFound();
        }
        return View(odontologos);
    }

    // POST: ODONTOLOGOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int idodontologo, Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Update(idodontologo, odontologo);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(odontologo);
        }
    }

    // GET: ODONTOLOGOS/Delete/5
    public ActionResult Delete(int idodontologo)
    {
        var odontologo = CRUD<Odontologo>.GetById(idodontologo);
        if (odontologo == null)
        {
            return NotFound();
        }
        return View(odontologo);
    }

    // POST: ODONTOLOGOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int idodontologo, Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Delete(idodontologo);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }

    
}
