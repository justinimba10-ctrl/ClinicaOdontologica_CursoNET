
using Microsoft.AspNetCore.Mvc;
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;

public class DetalleCitasController : Controller
{
        // GET: DETALLECITAS
    public ActionResult Index()    
    {
        var detallecitas = CRUD<DetalleCita>.GetAll();
        return View(detallecitas);
    }

    // GET: DETALLECITAS/Details/5
    public ActionResult Details(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if(iddetallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // GET: DETALLECITAS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: DETALLECITAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Create(detallecita);
            return RedirectToAction(nameof(Index));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(detallecita);

        }
    }

    // GET: DETALLECITAS/Edit/5
    public ActionResult Edit(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if(detallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // POST: DETALLECITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int iddetallecita, DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Update(iddetallecita, detallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(detallecita);
        }
    }

    // GET: DETALLECITAS/Delete/5
    public ActionResult Delete(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if(detallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // POST: DETALLECITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int iddetallecita, DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Delete(iddetallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }

    
}
