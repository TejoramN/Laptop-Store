using Laptop_Store.Data;
using Laptop_Store.Models;
using Laptop_Store.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Laptop_Store.Controllers;
[Area("Admin")]

public class CategoryController : Controller
{
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
             IEnumerable<Category> objCategoryList = _unitOfWork.Category.GetAll();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
          return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString()) {

                ModelState.AddModelError("CustomError", "The Display Order cannot exactly match with the Name");
            }
            if (ModelState.IsValid) {

                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "category Created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var categoryFromDb = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);

            if (categoryFromDb == null) {

                return NotFound();
            }
            return View(categoryFromDb);
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {

                ModelState.AddModelError("CustomError", "The Display Order cannot exactly match with the Name");
            }
            if (ModelState.IsValid)
            {

                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "category Updated successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _unitOfWork.Category.GetFirstOrDefault(u=> u.Id == id);

            if (categoryFromDb == null)
            {

                return NotFound();
            }
            return View(categoryFromDb);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) {

                return NotFound();
            }
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "category Deleted successfully";
            return RedirectToAction("Index");


        }
    }

