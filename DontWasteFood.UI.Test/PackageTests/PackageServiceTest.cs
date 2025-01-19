using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Service;
using NSubstitute;

namespace DontWasteFood.UI.Test.PackageTests
{
    public class PackageServiceTest
    {
        // Use case 1
        [Fact]
        public void Student_Can_View_All_Available_Packages()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            packageRepo.GetAllAvailablePackages(null, null).Returns(new List<Package>
                        {
                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Broodpakket",
                                MealType = MealType.Brood,
                                DateOfPickUp = DateTime.Now,
                                Price = 1.50M,
                                ReservedBy = null,
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                }

                            },

                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Warmemaaltijd",
                                MealType = MealType.Warme_Maaltijd,
                                DateOfPickUp = DateTime.Now,
                                Price = 2.50M,
                                ReservedBy = new Student
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "John Doe",
                                    StudentNumber = "12345678",
                                    EmailAddress = "j.doe@student.avans.nl",
                                    City = City.Breda

                                },
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                },

                            },
                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Broodpakket",
                                MealType = MealType.Brood,
                                DateOfPickUp = DateTime.Now,
                                Price = 1.50M,
                                ReservedBy = null,
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                }
                            },
                    }.AsQueryable());

            // Act
            var availablePackages = packageRepo.GetAllAvailablePackages(null, null)
                .Where(p => p.ReservedBy == null)
                .ToList();

            // Assert
            Assert.NotNull(availablePackages);
            Assert.Equal(2, availablePackages.Count());

        }

        [Fact]
        public void Student_Can_View_Their_Reserved_Packages()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var student = new Student
            {
                Id = studentId,
                Name = "John Doe",
                StudentNumber = "12345678",
                EmailAddress = "j.doe@student.avans.nl",
                City = City.Breda
            };

            studentRepo.Add(student);
            packageRepo.GetAllAsync().Returns(new List<Package>
                    {
                        new Package
                        {
                            Id = Guid.NewGuid(),
                            Name = "Broodpakket",
                            MealType = MealType.Brood,
                            DateOfPickUp = DateTime.Now,
                            Price = 1.50M,
                            ReservedBy = student
                        },
                        new Package
                        {
                            Id = Guid.NewGuid(),
                            Name = "Warmemaaltijd",
                            MealType = MealType.Warme_Maaltijd,
                            DateOfPickUp = DateTime.Now,
                            Price = 2.50M,
                            ReservedBy = new Student
                            {
                                Id = Guid.NewGuid(),
                                Name = "Jane Doe",
                                StudentNumber = "12345678",
                                EmailAddress = "jane.doe@student.avans.nl",
                                City = City.Breda
                            }
                        }
                    }.AsQueryable());

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedPackages = service.GetReservationsByStudentId(student.Id);

            // Assert
            Assert.Single(reservedPackages);
            Assert.All(reservedPackages, p => Assert.Equal(student.Id, p.ReservedBy?.Id));
            Assert.NotNull(reservedPackages);
        }

        // Use case 2
        [Fact]
        public void CanteenWorker_Can_View_Packages_In_Their_Own_Canteen()
        {
            // Arrange
            var canteenRepo = Substitute.For<ICanteenRepository>();
            var canteenWorkerRepo = Substitute.For<ICanteenWorkerRepository>();
            var packageRepo = Substitute.For<IPackageRepository>();

            var canteenWorkerId = new Guid("a91b0570-347b-4e67-9683-84586aac676b");
            var canteenId = new Guid("6705cc03-63d4-4d57-8be5-ccc97aadd2f9");

            canteenWorkerRepo.GetUserById(canteenWorkerId).Returns(new CanteenWorker
            {
                Id = canteenWorkerId,
                Name = "John Doe",
                EmployeeNumber = "12345678",
                Canteen = new Canteen
                {
                    Id = canteenId,
                    City = City.Breda,
                    CanteenLocation = "LA"
                }
            });

            canteenRepo.FindById(canteenId).Returns(new Canteen
            {
                Id = canteenId,
                City = City.Breda,
                CanteenLocation = "LA",
            });

            packageRepo.GetAllAsync().Returns(new List<Package>
            {
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Broodpakket",
                    MealType = MealType.Brood,
                    DateOfPickUp = DateTime.Now,
                    Price = 1.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                },
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Warmemaaltijd",
                    MealType = MealType.Warme_Maaltijd,
                    DateOfPickUp = DateTime.Now,
                    Price = 2.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                }
            }.AsQueryable());

            // Act
            var canteenPackages = new CanteenService(packageRepo, canteenRepo, canteenWorkerRepo).GetPackagesForCanteen(canteenId);

            // Assert
            Assert.NotNull(canteenPackages);
            Assert.Equal(2, canteenPackages.Count());
            Assert.All(canteenPackages, p => Assert.Equal(canteenId, p.Canteen?.Id));
        }

        [Fact]
        public void CanteenWorker_Can_View_Packages_In_Other_Canteens()
        {
            // Arrange
            var canteenRepo = Substitute.For<ICanteenRepository>();
            var canteenWorkerRepo = Substitute.For<ICanteenWorkerRepository>();
            var packageRepo = Substitute.For<IPackageRepository>();
            var canteenWorkerId = new Guid("a91b0570-347b-4e67-9683-84586aac676b");
            var canteenId = new Guid("6705cc03-63d4-4d57-8be5-ccc97aadd2f9");
            canteenWorkerRepo.GetUserById(canteenWorkerId).Returns(new CanteenWorker
            {
                Id = canteenWorkerId,
                Name = "John Doe",
                EmployeeNumber = "12345678",
                Canteen = new Canteen
                {
                    Id = canteenId,
                    City = City.Breda,
                    CanteenLocation = "LA"
                }
            });
            canteenRepo.FindById(canteenId).Returns(new Canteen
            {
                Id = canteenId,
                City = City.Breda,
                CanteenLocation = "LA",
            });
            packageRepo.GetAllAsync().Returns(new List<Package>
            {
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Broodpakket",
                    MealType = MealType.Brood,
                    DateOfPickUp = DateTime.Now,
                    Price = 1.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                },
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Warmemaaltijd",
                    MealType = MealType.Warme_Maaltijd,
                    DateOfPickUp = DateTime.Now,
                    Price = 2.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = Guid.NewGuid(),
                        City = City.Tilburg,
                        CanteenLocation = "TL"
                    }
                }
            }.AsQueryable());

            // Act
            var otherCanteenPackages = new CanteenService(packageRepo, canteenRepo, canteenWorkerRepo).GetPackagesForOtherCanteen(canteenId);
            // Assert
            Assert.NotNull(otherCanteenPackages);
            Assert.Single(otherCanteenPackages);
            Assert.All(otherCanteenPackages, p => Assert.NotEqual(canteenId, p.Canteen?.Id));
        }

        // Use case 3
        [Fact]
        public void Add_Package_Should_Be_A_Succes()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();

            var productId = Guid.NewGuid();
            var products = new List<Product>
            {
                new Product {
                    Id = productId,
                    Name = "Panini",
                    IsAlcoholic = false
                }
            };

            var addPackage = new Package
            {
                Id = Guid.NewGuid(),
                Name = "BroodPakket",
                DateOfPickUp = DateTime.Now.AddDays(1),
                TimeOfPickUp = DateTime.Now,
                MealType = MealType.Brood,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                Products = products,
                ReservedBy = null
            };
            productRepo.GetProductByIdAsync(productId).Returns(products.FirstOrDefault(p => p.Id == productId));

            var service = new PackageService(packageRepo, productRepo);

            // Act
            var result = service.AddPackage(addPackage);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Add_Package_Should_Return_False_If_DateOfPickUp_Is_Too_Far_In_The_Future()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();

            var productId = Guid.NewGuid();
            var products = new List<Product>
            {
                new Product {
                    Id = productId,
                    Name = "Panini",
                    IsAlcoholic = false
                }
            };

            var addPackage = new Package
            {
                Id = Guid.NewGuid(),
                Name = "BroodPakket",
                DateOfPickUp = DateTime.Now.AddDays(5),
                TimeOfPickUp = DateTime.Now,
                MealType = MealType.Brood,
                Price = 1.50m,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                Products = products,
                ReservedBy = null
            };
            productRepo.GetProductByIdAsync(productId).Returns(products.FirstOrDefault(p => p.Id == productId));

            var service = new PackageService(packageRepo, productRepo);

            // Act
            var result = service.AddPackage(addPackage);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task Update_Package_Should_Update_With_No_Reservation()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var productId = Guid.NewGuid();
            var packageId = Guid.NewGuid();

            var products = new List<Product> { new Product { Id = productId, Name = "Product 1", IsAlcoholic = false } };

            var package = new Package
            {
                Id = packageId,
                Name = "Package 1",
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                MealType = MealType.Anders,
                ReservedBy = null,
                Price = 1.50m,
                Products = products,
            };

            packageRepo.GetPackageByIdAsync(packageId).Returns(package);
            productRepo.GetProductByIdAsync(productId).Returns(products.FirstOrDefault(p => p.Id == productId));

            var service = new PackageService(packageRepo, productRepo);

            // Act
            await service.UpdatePackage(packageId, package);

            // Assert
            var updatedPackage = await packageRepo.GetPackageByIdAsync(packageId);
            Assert.NotNull(updatedPackage);
            Assert.Null(updatedPackage.ReservedBy);
            Assert.Equal(package.Name, updatedPackage.Name);
            Assert.Equal(package.MealType, updatedPackage.MealType);
            Assert.Equal(package.Price, updatedPackage.Price);
            Assert.Equal(package.Products.Count, updatedPackage.Products.Count);

        }

        [Fact]
        public async Task Update_Package_Should_Not_Update_With_A_Reservation()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var productId = Guid.NewGuid();
            var packageId = Guid.NewGuid();

            var products = new List<Product> { new Product { Id = productId, Name = "Product 1", IsAlcoholic = false } };

            var package = new Package
            {
                Id = packageId,
                Name = "Package 1",
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                MealType = MealType.Anders,
                ReservedBy = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    StudentNumber = "12345678",
                    EmailAddress = "j.doe@student.avans.nl",
                    City = City.Breda
                },
                Price = 1.50m,
                Products = products,
            };

            packageRepo.GetPackageByIdAsync(packageId).Returns(package);
            productRepo.GetProductByIdAsync(productId).Returns(products.FirstOrDefault(p => p.Id == productId));

            var service = new PackageService(packageRepo, productRepo);

            // Act
            await service.UpdatePackage(packageId, package);

            // Assert
            var updatedPackage = await packageRepo.GetPackageByIdAsync(packageId);
            Assert.NotNull(updatedPackage);
            Assert.Equal(package.ReservedBy.Id, updatedPackage.ReservedBy?.Id); 
            Assert.Equal(package.Name, updatedPackage.Name);
            Assert.Equal(package.MealType, updatedPackage.MealType);
            Assert.Equal(package.Price, updatedPackage.Price);
            Assert.Equal(package.Products.Count, updatedPackage.Products.Count);

        }

        [Fact]
        public void Delete_Package_Without_A_Reservation()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var packageId = Guid.NewGuid();
            var package = new Package
            {
                Id = packageId,
                Name = "Package 1",
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                MealType = MealType.Anders,
                ReservedBy = null,
                Price = 1.50m,
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Product 1",
                        IsAlcoholic = false
                    }
                }
            };
            packageRepo.GetPackageByIdAsync(packageId).Returns(package);
            var service = new PackageService(packageRepo, productRepo);

            // Act
            service.DeletePackage(package);

            // Assert
            packageRepo.Received().Delete(package);
        }

        [Fact]
        public void Delete_Package_With_A_Reservation_Should_Not_Be_Deleted()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var packageId = Guid.NewGuid();
            var package = new Package
            {
                Id = packageId,
                Name = "Package 1",
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                MealType = MealType.Anders,
                ReservedBy = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    StudentNumber = "12345678",
                    EmailAddress = "j.doe@student.avans.nl",
                    City = City.Breda
                },
                Price = 1.50m,
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Product 1",
                        IsAlcoholic = false
                    }
                }
            };
            packageRepo.GetPackageByIdAsync(packageId).Returns(package);
            var service = new PackageService(packageRepo, productRepo);

            // Act
            service.DeletePackage(package);

            // Assert
            packageRepo.DidNotReceive().Delete(package);
        }

        // Use case 4
        [Fact]
        public static void Add_Package_Should_Set_18PlusStatus_If_Package_Contains_Alcohol()
        {
            // Assert
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();

            var productId = Guid.NewGuid();
            var products = new List<Product>
                {
                    new Product {
                        Id = productId,
                        Name = "Amstel Bier",
                        IsAlcoholic = true
                    }
                };

            var addPackage = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Amstel Bier",
                DateOfPickUp = DateTime.Now.AddDays(1),
                TimeOfPickUp = DateTime.Now,
                MealType = MealType.Drank,
                Price = 20.0m,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    City = City.Breda,
                    CanteenLocation = "LD"
                },
                Products = products,
                ReservedBy = null
            };

            addPackage.Is18PlusStatus();

            productRepo.GetProductByIdAsync(productId).Returns(products.FirstOrDefault(p => p.Id == productId));

            var service = new PackageService(packageRepo, productRepo);

            // Act
            var result = service.AddPackage(addPackage);

            // Assert
            Assert.True(result);
            Assert.True(addPackage.Is18Plus);
        }

        [Fact]
        public async Task Student_Can_Reserve_A_Package_If_18Plus()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var studentId = Guid.NewGuid();
            var productId = Guid.NewGuid();
            var packageId = Guid.NewGuid();

            var student = new Student
            {
                Id = studentId,
                Name = "Jane Doe",
                City = City.Breda,
                StudentNumber = "12345678",
                EmailAddress = "jane.doe@student.avans.nl",
            };
            student.UpdateDateOfBirth(new DateTime(2005, 1, 1)); 
            studentRepo.GetUserById(studentId).Returns(student);


            var package = new Package
            {
                Id = packageId,
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now.AddDays(1), 
                Price = 1.50M,
                Is18Plus = true,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                },
                Products = new List<Product> { new Product { Id = productId, Name = "Amstel Bier", IsAlcoholic = true } }
            };

            packageRepo.GetPackageByIdAsync(package.Id).Returns(package);
            productRepo.GetProductByIdAsync(productId).Returns(package.Products.FirstOrDefault(p => p.Id == productId));

            packageRepo.ReservePackageDirectlyAsync(package.Id, studentId).Returns(true);

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedPackage = await service.ReservePackageAsync(package.Id, studentId);

            // Assert
            Assert.NotNull(reservedPackage);
            Assert.Equal(studentId, reservedPackage?.ReservedBy?.Id);
            Assert.True(reservedPackage?.Is18Plus);
            Assert.True(reservedPackage?.ReservedBy?.Is18Plus(package.DateOfPickUp)); 
        }

        [Fact]
        public async Task Student_Can_Not_Reserve_A_Package_If_18Plus()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var productRepo = Substitute.For<IProductRepository>();
            var studentId = Guid.NewGuid();
            var productId = Guid.NewGuid();
            var packageId = Guid.NewGuid();

            var student = new Student
            {
                Id = studentId,
                Name = "Jane Doe",
                City = City.Breda,
                StudentNumber = "12345678",
                EmailAddress = "jane.doe@student.avans.nl",
            };
            student.UpdateDateOfBirth(new DateTime(2009, 1, 1)); 
            studentRepo.GetUserById(studentId).Returns(student);

            var package = new Package
            {
                Id = packageId,
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now.AddDays(1),
                Price = 1.50M,
                Is18Plus = true,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                },
                Products = new List<Product> { new Product { Id = productId, Name = "Amstel Bier", IsAlcoholic = true } }
            };

            packageRepo.GetPackageByIdAsync(package.Id).Returns(package);
            productRepo.GetProductByIdAsync(productId).Returns(package.Products.FirstOrDefault(p => p.Id == productId));

            packageRepo.ReservePackageDirectlyAsync(package.Id, studentId).Returns(true);

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedPackage = await service.ReservePackageAsync(package.Id, studentId);

            // Assert
            Assert.Null(reservedPackage);
        }

        // Use case 5
        [Fact]
        public async Task Student_Can_Reserve_A_Package()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var studentId = Guid.NewGuid();

            var student = new Student
            {
                Id = studentId,
                Name = "Jane Doe",
                City = City.Breda,
                StudentNumber = "12345678",
                EmailAddress = "jane.doe@student.avans.nl",

            };
            student.UpdateDateOfBirth(new DateTime(2000, 1, 1));
            studentRepo.GetUserById(studentId).Returns(student);

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now.AddDays(1),
                Price = 1.50M,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                }
            };

            packageRepo.GetPackageByIdAsync(package.Id).Returns(package);

            packageRepo.ReservePackageDirectlyAsync(package.Id, studentId).Returns(true);

            var service = new ReservationService(packageRepo, studentRepo); 

            // Act
            var reservedPackage = await service.ReservePackageAsync(package.Id, studentId);

            // Assert
            Assert.NotNull(reservedPackage);
            Assert.Equal(studentId, reservedPackage?.ReservedBy?.Id);
        }

        [Fact]
        public async Task Student_Cannot_Reserve_More_Than_One_Package_Per_Day()
        {
            // Arrange 
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var studentId = Guid.NewGuid();

            var student = new Student
            {
                Id = studentId,
                Name = "Jane Doe",
                City = City.Breda,
                StudentNumber = "12345678",
                EmailAddress = "jane.doe@student.avans.nl",
            };
            student.UpdateDateOfBirth(new DateTime(2000, 1, 1));
            studentRepo.GetUserById(studentId).Returns(student);

            var firstPackage = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now.AddDays(1), 
                Price = 1.50M,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                }
            };

            var secondPackage = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Fruitpakket",
                MealType = MealType.Anders,
                DateOfPickUp = firstPackage.DateOfPickUp, 
                Price = 2.00M,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                }
            };

            packageRepo.GetPackageByIdAsync(firstPackage.Id).Returns(firstPackage);
            packageRepo.GetPackageByIdAsync(secondPackage.Id).Returns(secondPackage);

            packageRepo.ReservePackageDirectlyAsync(firstPackage.Id, studentId).Returns(true);
            packageRepo.ReservePackageDirectlyAsync(secondPackage.Id, studentId).Returns(false);

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedFirstPackage = await service.ReservePackageAsync(firstPackage.Id, studentId);
            var reservedSecondPackage = await service.ReservePackageAsync(secondPackage.Id, studentId);

            // Assert
            Assert.NotNull(reservedFirstPackage);
            Assert.Null(reservedSecondPackage);

        }

        // Use case 6
        [Fact]
        public async Task Package_With_Id_Should_Return_Correct_Details()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var packageId = Guid.NewGuid();
            var package = new Package
            {
                Id = packageId,
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now,
                Price = 1.50M,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                },
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Brood",
                        IsAlcoholic = false
                    }
                }
            };
            packageRepo.GetPackageByIdAsync(packageId).Returns(package);

            // Act
            var packageDetails = await packageRepo.GetPackageByIdAsync(packageId);

            // Assert
            Assert.NotNull(packageDetails);
            Assert.Equal(packageId, packageDetails?.Id);
            Assert.Equal("Broodpakket", packageDetails?.Name);
            Assert.Equal(MealType.Brood, packageDetails?.MealType);
            Assert.Equal(1.50M, packageDetails?.Price);
            Assert.Null(packageDetails?.ReservedBy);
            Assert.NotNull(packageDetails?.Canteen);
            Assert.Equal("LA", packageDetails?.Canteen?.CanteenLocation);
            Assert.Equal(City.Breda, packageDetails?.Canteen?.City);
            Assert.NotNull(packageDetails?.Products);
            Assert.Single(packageDetails?.Products!);
        }

        // Use case 7
        [Fact]
        public async Task Student_Cannot_Reserve_Already_Reserved_Package()
        {
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var studentId = Guid.NewGuid();

            var student = new Student
            {
                Id = studentId,
                Name = "Jane Doe",
                City = City.Breda,
                StudentNumber = "12345678",
                EmailAddress = "jane.doe@student.avans.nl",
            };
            student.UpdateDateOfBirth(new DateTime(2000, 1, 1));

            studentRepo.GetUserById(studentId).Returns(student);

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now.AddDays(1),
                Price = 1.50M,
                ReservedBy = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    StudentNumber = "12345678",
                    EmailAddress = "j.doe@student.avans.nl",
                    City = City.Breda
                },
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                }
            };

            packageRepo.GetPackageByIdAsync(package.Id).Returns(package);
            packageRepo.ReservePackageDirectlyAsync(package.Id, studentId).Returns(false);

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedPackage = await service.ReservePackageAsync(package.Id, studentId);
            Assert.Null(reservedPackage?.ReservedBy);
        }

        // Use case 8
        [Fact]
        public void Student_Can_Filter_On_The_Available_Packages()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();

            var packages = new List<Package>
                {
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Broodpakket",
                        MealType = MealType.Brood,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.50M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "LA",
                            City = City.Breda
                        }
                    },
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Panini ham & kaas",
                        MealType = MealType.Brood,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.50M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "LA",
                            City = City.Breda
                        }
                    },
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Amstel bier",
                        MealType = MealType.Drank,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.75M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "TL",
                            City = City.Tilburg
                        }
                    }
                }.AsQueryable();

            packageRepo.GetAllAvailablePackages(City.Breda.ToString(), MealType.Brood.ToString())
            .Returns(packages.Where(p => p.Canteen != null && p.Canteen.City == City.Breda && p.MealType == MealType.Brood).AsQueryable());


            // Act
            var filterPackages = packageRepo.GetAllAvailablePackages(City.Breda.ToString(), MealType.Brood.ToString()).ToList();

            // Assert
            Assert.NotNull(filterPackages);
            Assert.Equal(2, filterPackages.Count());
            Assert.All(filterPackages, p => Assert.Equal(City.Breda.ToString(), p.Canteen?.City.ToString()));
            Assert.All(filterPackages, p => Assert.Equal(MealType.Brood.ToString(), p.MealType.ToString()));
        }

    }
}