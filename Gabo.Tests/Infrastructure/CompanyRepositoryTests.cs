using System;
using System.Collections.Generic;
using System.Text;
using Gabo.Infrastructure.Context;
using Gabo.Infrastructure.Interfaces;
using Gabo.Infrastructure.Repositories;
using Gabo.Models.Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gabo.Tests.Infrastructure
{
    [TestClass]
    public class CompanyRepositoryTests
    {
        [TestMethod]
        public void Insert_NewCompany_InsertsSuccessfully()
        {
            // Arrange
            GaboContext gaboContext = new GaboContext();
            ICompanyRepository companyRepository = new CompanyRepository(gaboContext);
            Company newCompany = new Company()
            {
                Name = "Gabo Enterprise",
                City = "Medellín",
                Nit = 123
            };

            // Act
            var beforeNumberOfCompanies = companyRepository.GetAll().Count;
            companyRepository.Insert(newCompany);
            var afterNumberOfCompanies = companyRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(beforeNumberOfCompanies + 1, afterNumberOfCompanies);
        }

        [TestMethod]
        public void GetAll_AllCompanies_RetrievesAllCompanies()
        {
            // Arrange
            GaboContext gaboContext = new GaboContext();
            ICompanyRepository companyRepository = new CompanyRepository(gaboContext);

            // Act
            var companies = companyRepository.GetAll();

            // Assert
            Assert.IsTrue(companies.Count > 0);
        }
    }
}
