﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AberFitnessLayout.Models;
using LayoutService.Models;
using LayoutService.Repositories;

namespace LayoutService.Controllers
{
    public class AppSubLinksManagementController : Controller
    {
        private readonly IAppSubLinkRepository appSubLinkRepository;

        public AppSubLinksManagementController(IAppSubLinkRepository appSubLinkRepository)
        {
            this.appSubLinkRepository = appSubLinkRepository;
        }

        // GET: AppSubLinksManagement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppSubLinksManagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DisplayName,Uri,AccessLevel,AppLinkId")] AppSubLink appSubLink)
        {
            if (ModelState.IsValid)
            {
                await appSubLinkRepository.AddAsync(appSubLink);
                return RedirectToAction(nameof(AppLinksManagementController.Edit), "AppLinksManagement", new { Id = appSubLink.AppLinkId });
            }
            return View(appSubLink);
        }

        // GET: AppSubLinksManagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appSubLink = await appSubLinkRepository.GetByIdAsync(id.Value);
            if (appSubLink == null)
            {
                return NotFound();
            }
            return View(appSubLink);
        }

        // POST: AppSubLinksManagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DisplayName,Uri,AccessLevel,AppLinkId")] AppSubLink appSubLink)
        {
            if (id != appSubLink.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await appSubLinkRepository.UpdateAsync(appSubLink);
                return RedirectToAction(nameof(AppLinksManagementController.Edit), "AppLinksManagement", new { Id = appSubLink.AppLinkId });
            }
            return View(appSubLink);
        }

        // GET: AppSubLinksManagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appSubLink = await appSubLinkRepository.GetByIdAsync(id.Value);
            if (appSubLink == null)
            {
                return NotFound();
            }

            return View(appSubLink);
        }

        // POST: AppSubLinksManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appSubLink = await appSubLinkRepository.GetByIdAsync(id);
            await appSubLinkRepository.DeleteAsync(appSubLink);
            return RedirectToAction(nameof(AppLinksManagementController.Edit), "AppLinksManagement", new { Id = appSubLink.AppLinkId });
        }
    }
}