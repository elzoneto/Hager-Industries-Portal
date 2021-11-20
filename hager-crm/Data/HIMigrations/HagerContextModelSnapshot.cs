﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hager_crm.Data;

namespace hager_crm.Data.HIMigrations
{
    [DbContext(typeof(HagerContext))]
    partial class HagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("hager_crm.Models.Announcement", b =>
                {
                    b.Property<int>("AnnouncementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Severity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(64);

                    b.HasKey("AnnouncementID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("hager_crm.Models.AnnouncementEmployee", b =>
                {
                    b.Property<int>("AnnouncementEmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnnouncementID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnnouncementEmployeeID");

                    b.HasIndex("AnnouncementID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AnnouncementEmployees");
                });

            modelBuilder.Entity("hager_crm.Models.BillingTerm", b =>
                {
                    b.Property<int>("BillingTermID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Terms")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("BillingTermID");

                    b.ToTable("BillingTerms");
                });

            modelBuilder.Entity("hager_crm.Models.Calendar", b =>
                {
                    b.Property<int>("CalendarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("CalendarId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("hager_crm.Models.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("hager_crm.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("BillingAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("BillingCity")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BillingCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BillingProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BillingTermID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContractorTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CreditCheck")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrencyID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateChecked")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<long?>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingAddress1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("ShippingAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingCity")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShippingCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShippingProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VendorTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("CompanyID");

                    b.HasIndex("BillingCountryID");

                    b.HasIndex("BillingProvinceID");

                    b.HasIndex("BillingTermID");

                    b.HasIndex("ContractorTypeID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("CustomerTypeID");

                    b.HasIndex("ShippingCountryID");

                    b.HasIndex("ShippingProvinceID");

                    b.HasIndex("VendorTypeID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("hager_crm.Models.CompanyContractor", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContractorTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyID", "ContractorTypeID");

                    b.HasIndex("ContractorTypeID");

                    b.ToTable("CompanyContractors");
                });

            modelBuilder.Entity("hager_crm.Models.CompanyCustomer", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompanyID", "CustomerTypeID");

                    b.HasIndex("CustomerTypeID");

                    b.ToTable("CompanyCustomers");
                });

            modelBuilder.Entity("hager_crm.Models.CompanyVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendorTypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompanyID", "VendorTypeID");

                    b.HasIndex("VendorTypeID");

                    b.ToTable("CompanyVendors");
                });

            modelBuilder.Entity("hager_crm.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CellPhone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<long?>("WorkPhone")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("hager_crm.Models.ContactCategories", b =>
                {
                    b.Property<int>("CategoriesID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContactID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesID", "ContactID");

                    b.HasIndex("ContactID");

                    b.ToTable("ContactCategories");
                });

            modelBuilder.Entity("hager_crm.Models.ContractorType", b =>
                {
                    b.Property<int>("ContractorTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("ContractorTypeID");

                    b.ToTable("ContractorTypes");
                });

            modelBuilder.Entity("hager_crm.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryAbbr")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("hager_crm.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("CurrencyID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("hager_crm.Models.CustomerType", b =>
                {
                    b.Property<int>("CustomerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("hager_crm.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CellPhone")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("EmergencyContactName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<long?>("EmergencyContactPhone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeAddress1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("EmployeeAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("EmployeeCity")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeePostalCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmploymentTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Expense")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int?>("JobPositionID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KeyFob")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Wage")
                        .HasColumnType("TEXT");

                    b.Property<long?>("WorkPhone")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("EmployeeCountryID");

                    b.HasIndex("EmployeeProvinceID");

                    b.HasIndex("EmploymentTypeID");

                    b.HasIndex("JobPositionID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("hager_crm.Models.EmploymentType", b =>
                {
                    b.Property<int>("EmploymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("EmploymentTypeID");

                    b.ToTable("EmploymentTypes");
                });

            modelBuilder.Entity("hager_crm.Models.JobPosition", b =>
                {
                    b.Property<int>("JobPositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("JobPositionID");

                    b.ToTable("JobPositions");
                });

            modelBuilder.Entity("hager_crm.Models.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceAbbr")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("ProvinceID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("hager_crm.Models.VendorType", b =>
                {
                    b.Property<int>("VendorTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("VendorTypeID");

                    b.ToTable("VendorTypes");
                });

            modelBuilder.Entity("hager_crm.Models.AnnouncementEmployee", b =>
                {
                    b.HasOne("hager_crm.Models.Announcement", "Announcement")
                        .WithMany("EmployeesUnread")
                        .HasForeignKey("AnnouncementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Employee", "Employee")
                        .WithMany("UnreadAnnouncements")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.Calendar", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("Calendars")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.Company", b =>
                {
                    b.HasOne("hager_crm.Models.Country", "BillingCountry")
                        .WithMany("Companies")
                        .HasForeignKey("BillingCountryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.Province", "BillingProvince")
                        .WithMany("Companies")
                        .HasForeignKey("BillingProvinceID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.BillingTerm", "BillingTerm")
                        .WithMany("Companies")
                        .HasForeignKey("BillingTermID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.ContractorType", null)
                        .WithMany("Companies")
                        .HasForeignKey("ContractorTypeID");

                    b.HasOne("hager_crm.Models.Currency", "Currency")
                        .WithMany("Companies")
                        .HasForeignKey("CurrencyID");

                    b.HasOne("hager_crm.Models.CustomerType", null)
                        .WithMany("Companies")
                        .HasForeignKey("CustomerTypeID");

                    b.HasOne("hager_crm.Models.Country", "ShippingCountry")
                        .WithMany()
                        .HasForeignKey("ShippingCountryID");

                    b.HasOne("hager_crm.Models.Province", "ShippingProvince")
                        .WithMany()
                        .HasForeignKey("ShippingProvinceID");

                    b.HasOne("hager_crm.Models.VendorType", null)
                        .WithMany("Companies")
                        .HasForeignKey("VendorTypeID");
                });

            modelBuilder.Entity("hager_crm.Models.CompanyContractor", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("CompanyContractors")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.ContractorType", "ContractorType")
                        .WithMany("CompanyContractors")
                        .HasForeignKey("ContractorTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.CompanyCustomer", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("CompanyCustomers")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.CustomerType", "CustomerType")
                        .WithMany("CompanyCustomers")
                        .HasForeignKey("CustomerTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.CompanyVendor", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("CompanyVendors")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.VendorType", "VendorType")
                        .WithMany("CompanyVendors")
                        .HasForeignKey("VendorTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.Contact", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.ContactCategories", b =>
                {
                    b.HasOne("hager_crm.Models.Categories", "Categories")
                        .WithMany("ContactCategories")
                        .HasForeignKey("CategoriesID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Contact", "Contact")
                        .WithMany("ContactCategories")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.Employee", b =>
                {
                    b.HasOne("hager_crm.Models.Country", "EmployeeCountry")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeCountryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.Province", "EmployeeProvince")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeProvinceID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.EmploymentType", "EmploymentType")
                        .WithMany("Employees")
                        .HasForeignKey("EmploymentTypeID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.JobPosition", "JobPosition")
                        .WithMany("Employees")
                        .HasForeignKey("JobPositionID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
