﻿using Entiteter.Personer;
using Entiteter.Prislistor;
using Entiteter.Tjänster;
using Microsoft.EntityFrameworkCore;

namespace Datalager.Seed
{
    public static class Seed
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {

            #region --------------------------------------------Ladda användare
            modelBuilder.Entity<Användare>().HasData(
                new Användare()
                {
                    //AnvändarID = 55,
                    Behörighetsnivå = 1,
                    Användarnamn = "Anders",
                    Lösenord = "a",
                    Efternamn = "Otterberg",
                    Förnamn = "Magnifike"
                }
                );

            #endregion Ladda användare

            #region --------------------------------------------Ladda Logi
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 1,
                TypAvLogi = "LGH.I",
                Vecka = 1,
                PrisVardag = 415,
                PrisHelg = 725,
                PrisVecka = 2895,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 2,
                TypAvLogi = "LGH.I",
                Vecka = 2,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 3,
                TypAvLogi = "LGH.I",
                Vecka = 3,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 4,
                TypAvLogi = "LGH.I",
                Vecka = 4,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 5,
                TypAvLogi = "LGH.I",
                Vecka = 5,
                PrisVardag = 270,
                PrisHelg = 410,
                PrisVecka = 1895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 6,
                TypAvLogi = "LGH.I",
                Vecka = 6,
                PrisVardag = 270,
                PrisHelg = 410,
                PrisVecka = 1895,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 7,
                TypAvLogi = "LGH.I",
                Vecka = 7,
                PrisVardag = 0,
                PrisHelg = 0,
                PrisVecka = 3895,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 8,
                TypAvLogi = "LGH.I",
                Vecka = 8,
                PrisVardag = 0,
                PrisHelg = 0,
                PrisVecka = 3895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 9,
                TypAvLogi = "LGH.I",
                Vecka = 9,
                PrisVardag = 415,
                PrisHelg = 725,
                PrisVecka = 2895,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 10,
                TypAvLogi = "LGH.I",
                Vecka = 10,
                PrisVardag = 300,
                PrisHelg = 455,
                PrisVecka = 2095,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 11,
                TypAvLogi = "LGH.I",
                Vecka = 11,
                PrisVardag = 300,
                PrisHelg = 455,
                PrisVecka = 2095,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 12,
                TypAvLogi = "LGH.I",
                Vecka = 12,
                PrisVardag = 300,
                PrisHelg = 455,
                PrisVecka = 2095,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 13,
                TypAvLogi = "LGH.I",
                Vecka = 13,
                PrisVardag = 415,
                PrisHelg = 725,
                PrisVecka = 2895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 14,
                TypAvLogi = "LGH.I",
                Vecka = 14,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 15,
                TypAvLogi = "LGH.I",
                Vecka = 15,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 16,
                TypAvLogi = "LGH.I",
                Vecka = 16,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 17,
                TypAvLogi = "LGH.I",
                Vecka = 17,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 18,
                TypAvLogi = "LGH.I",
                Vecka = 18,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 19,
                TypAvLogi = "LGH.I",
                Vecka = 19,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 20,
                TypAvLogi = "LGH.I",
                Vecka = 20,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 21,
                TypAvLogi = "LGH.I",
                Vecka = 21,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 22,
                TypAvLogi = "LGH.I",
                Vecka = 22,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 23,
                TypAvLogi = "LGH.I",
                Vecka = 23,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 24,
                TypAvLogi = "LGH.I",
                Vecka = 24,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 25,
                TypAvLogi = "LGH.I",
                Vecka = 25,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 26,
                TypAvLogi = "LGH.I",
                Vecka = 26,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 27,
                TypAvLogi = "LGH.I",
                Vecka = 27,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 28,
                TypAvLogi = "LGH.I",
                Vecka = 28,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 29,
                TypAvLogi = "LGH.I",
                Vecka = 29,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 30,
                TypAvLogi = "LGH.I",
                Vecka = 30,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 31,
                TypAvLogi = "LGH.I",
                Vecka = 31,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 32,
                TypAvLogi = "LGH.I",
                Vecka = 32,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 33,
                TypAvLogi = "LGH.I",
                Vecka = 33,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 34,
                TypAvLogi = "LGH.I",
                Vecka = 34,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 35,
                TypAvLogi = "LGH.I",
                Vecka = 35,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 36,
                TypAvLogi = "LGH.I",
                Vecka = 36,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 37,
                TypAvLogi = "LGH.I",
                Vecka = 37,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 38,
                TypAvLogi = "LGH.I",
                Vecka = 38,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 39,
                TypAvLogi = "LGH.I",
                Vecka = 39,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 40,
                TypAvLogi = "LGH.I",
                Vecka = 40,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 41,
                TypAvLogi = "LGH.I",
                Vecka = 41,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 42,
                TypAvLogi = "LGH.I",
                Vecka = 42,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 43,
                TypAvLogi = "LGH.I",
                Vecka = 43,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 44,
                TypAvLogi = "LGH.I",
                Vecka = 44,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 45,
                TypAvLogi = "LGH.I",
                Vecka = 45,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 46,
                TypAvLogi = "LGH.I",
                Vecka = 46,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 47,
                TypAvLogi = "LGH.I",
                Vecka = 47,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 48,
                TypAvLogi = "LGH.I",
                Vecka = 48,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 49,
                TypAvLogi = "LGH.I",
                Vecka = 49,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 50,
                TypAvLogi = "LGH.I",
                Vecka = 50,
                PrisVardag = 200,
                PrisHelg = 200,
                PrisVecka = 1300,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 51,
                TypAvLogi = "LGH.I",
                Vecka = 51,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 52,
                TypAvLogi = "LGH.I",
                Vecka = 52,
                PrisVardag = 240,
                PrisHelg = 370,
                PrisVecka = 1695,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 53,
                TypAvLogi = "LGH.II",
                Vecka = 1,
                PrisVardag = 555,
                PrisHelg = 975,
                PrisVecka = 3895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 54,
                TypAvLogi = "LGH.II",
                Vecka = 2,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 55,
                TypAvLogi = "LGH.II",
                Vecka = 3,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 56,
                TypAvLogi = "LGH.II",
                Vecka = 4,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 57,
                TypAvLogi = "LGH.II",
                Vecka = 5,
                PrisVardag = 370,
                PrisHelg = 565,
                PrisVecka = 2595,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 58,
                TypAvLogi = "LGH.II",
                Vecka = 6,
                PrisVardag = 370,
                PrisHelg = 565,
                PrisVecka = 2595,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 59,
                TypAvLogi = "LGH.II",
                Vecka = 7,
                PrisVardag = 0,
                PrisHelg = 0,
                PrisVecka = 4995,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 60,
                TypAvLogi = "LGH.II",
                Vecka = 8,
                PrisVardag = 0,
                PrisHelg = 0,
                PrisVecka = 4995,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 156,
                TypAvLogi = "LGH.II",
                Vecka = 9,
                PrisVardag = 555,
                PrisHelg = 975,
                PrisVecka = 3895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 61,
                TypAvLogi = "LGH.II",
                Vecka = 10,
                PrisVardag = 440,
                PrisHelg = 670,
                PrisVecka = 3095,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 62,
                TypAvLogi = "LGH.II",
                Vecka = 11,
                PrisVardag = 440,
                PrisHelg = 670,
                PrisVecka = 3095,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 63,
                TypAvLogi = "LGH.II",
                Vecka = 12,
                PrisVardag = 440,
                PrisHelg = 670,
                PrisVecka = 3095,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 157,
                TypAvLogi = "LGH.II",
                Vecka = 13,
                PrisVardag = 555,
                PrisHelg = 975,
                PrisVecka = 3895,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 64,
                TypAvLogi = "LGH.II",
                Vecka = 14,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 65,
                TypAvLogi = "LGH.II",
                Vecka = 15,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 66,
                TypAvLogi = "LGH.II",
                Vecka = 16,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 67,
                TypAvLogi = "LGH.II",
                Vecka = 17,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 68,
                TypAvLogi = "LGH.II",
                Vecka = 18,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 69,
                TypAvLogi = "LGH.II",
                Vecka = 19,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 70,
                TypAvLogi = "LGH.II",
                Vecka = 20,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 71,
                TypAvLogi = "LGH.II",
                Vecka = 21,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 72,
                TypAvLogi = "LGH.II",
                Vecka = 22,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 73,
                TypAvLogi = "LGH.II",
                Vecka = 23,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 74,
                TypAvLogi = "LGH.II",
                Vecka = 24,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 75,
                TypAvLogi = "LGH.II",
                Vecka = 25,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 76,
                TypAvLogi = "LGH.II",
                Vecka = 26,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 77,
                TypAvLogi = "LGH.II",
                Vecka = 27,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 78,
                TypAvLogi = "LGH.II",
                Vecka = 28,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 79,
                TypAvLogi = "LGH.II",
                Vecka = 29,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 80,
                TypAvLogi = "LGH.II",
                Vecka = 30,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 81,
                TypAvLogi = "LGH.II",
                Vecka = 31,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 82,
                TypAvLogi = "LGH.II",
                Vecka = 32,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 83,
                TypAvLogi = "LGH.II",
                Vecka = 33,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 84,
                TypAvLogi = "LGH.II",
                Vecka = 34,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 85,
                TypAvLogi = "LGH.II",
                Vecka = 35,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 86,
                TypAvLogi = "LGH.II",
                Vecka = 36,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 87,
                TypAvLogi = "LGH.II",
                Vecka = 37,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 88,
                TypAvLogi = "LGH.II",
                Vecka = 38,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 89,
                TypAvLogi = "LGH.II",
                Vecka = 39,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 90,
                TypAvLogi = "LGH.II",
                Vecka = 40,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 91,
                TypAvLogi = "LGH.II",
                Vecka = 41,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 92,
                TypAvLogi = "LGH.II",
                Vecka = 42,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 93,
                TypAvLogi = "LGH.II",
                Vecka = 43,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 94,
                TypAvLogi = "LGH.II",
                Vecka = 44,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 95,
                TypAvLogi = "LGH.II",
                Vecka = 45,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 96,
                TypAvLogi = "LGH.II",
                Vecka = 46,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 97,
                TypAvLogi = "LGH.II",
                Vecka = 47,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 98,
                TypAvLogi = "LGH.II",
                Vecka = 48,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 99,
                TypAvLogi = "LGH.II",
                Vecka = 49,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 100,
                TypAvLogi = "LGH.II",
                Vecka = 50,
                PrisVardag = 230,
                PrisHelg = 230,
                PrisVecka = 1400,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 101,
                TypAvLogi = "LGH.II",
                Vecka = 51,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 102,
                TypAvLogi = "LGH.II",
                Vecka = 52,
                PrisVardag = 330,
                PrisHelg = 495,
                PrisVecka = 2295,
            });
            //blir ett hopp mellan ID 102 och 104 pga tidigare miss med PK(sök 103).
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 104,
                TypAvLogi = "Camp",
                Vecka = 1,
                PrisVardag = 170,
                PrisVecka = 1120,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 105,
                TypAvLogi = "Camp",
                Vecka = 2,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 106,
                TypAvLogi = "Camp",
                Vecka = 3,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 107,
                TypAvLogi = "Camp",
                Vecka = 4,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 108,
                TypAvLogi = "Camp",
                Vecka = 5,
                PrisVardag = 150,
                PrisVecka = 970,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 109,
                TypAvLogi = "Camp",
                Vecka = 6,
                PrisVardag = 150,
                PrisVecka = 970,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 110,
                TypAvLogi = "Camp",
                Vecka = 7,
                PrisVardag = 170,
                PrisVecka = 1120,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 111,
                TypAvLogi = "Camp",
                Vecka = 8,
                PrisVardag = 170,
                PrisVecka = 1120,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 112,
                TypAvLogi = "Camp",
                Vecka = 9,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 113,
                TypAvLogi = "Camp",
                Vecka = 10,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 114,
                TypAvLogi = "Camp",
                Vecka = 11,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 115,
                TypAvLogi = "Camp",
                Vecka = 12,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 116,
                TypAvLogi = "Camp",
                Vecka = 13,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 117,
                TypAvLogi = "Camp",
                Vecka = 14,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 118,
                TypAvLogi = "Camp",
                Vecka = 15,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 119,
                TypAvLogi = "Camp",
                Vecka = 16,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 120,
                TypAvLogi = "Camp",
                Vecka = 17,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 121,
                TypAvLogi = "Camp",
                Vecka = 18,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 122,
                TypAvLogi = "Camp",
                Vecka = 19,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 123,
                TypAvLogi = "Camp",
                Vecka = 20,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 124,
                TypAvLogi = "Camp",
                Vecka = 21,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 158,
                TypAvLogi = "Camp",
                Vecka = 22,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 125,
                TypAvLogi = "Camp",
                Vecka = 23,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 126,
                TypAvLogi = "Camp",
                Vecka = 24,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 127,
                TypAvLogi = "Camp",
                Vecka = 25,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 128,
                TypAvLogi = "Camp",
                Vecka = 26,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 129,
                TypAvLogi = "Camp",
                Vecka = 27,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 130,
                TypAvLogi = "Camp",
                Vecka = 28,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 131,
                TypAvLogi = "Camp",
                Vecka = 29,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 132,
                TypAvLogi = "Camp",
                Vecka = 30,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 133,
                TypAvLogi = "Camp",
                Vecka = 31,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 134,
                TypAvLogi = "Camp",
                Vecka = 32,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 135,
                TypAvLogi = "Camp",
                Vecka = 33,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 136,
                TypAvLogi = "Camp",
                Vecka = 33,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 137,
                TypAvLogi = "Camp",
                Vecka = 34,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 138,
                TypAvLogi = "Camp",
                Vecka = 35,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 139,
                TypAvLogi = "Camp",
                Vecka = 36,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 140,
                TypAvLogi = "Camp",
                Vecka = 37,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 141,
                TypAvLogi = "Camp",
                Vecka = 38,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 142,
                TypAvLogi = "Camp",
                Vecka = 39,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 143,
                TypAvLogi = "Camp",
                Vecka = 40,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 144,
                TypAvLogi = "Camp",
                Vecka = 41,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 145,
                TypAvLogi = "Camp",
                Vecka = 42,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 146,
                TypAvLogi = "Camp",
                Vecka = 43,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 147,
                TypAvLogi = "Camp",
                Vecka = 44,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 148,
                TypAvLogi = "Camp",
                Vecka = 45,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 149,
                TypAvLogi = "Camp",
                Vecka = 46,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 150,
                TypAvLogi = "Camp",
                Vecka = 47,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 151,
                TypAvLogi = "Camp",
                Vecka = 48,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 152,
                TypAvLogi = "Camp",
                Vecka = 49,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 153,
                TypAvLogi = "Camp",
                Vecka = 50,
                PrisVardag = 130,
                PrisVecka = 815,
            });

            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 154,
                TypAvLogi = "Camp",
                Vecka = 51,
                PrisVardag = 130,
                PrisVecka = 815,
            });
            modelBuilder.Entity<PrislistaLogi>().HasData(new PrislistaLogi()
            {
                PrisId = 155,
                TypAvLogi = "Camp",
                Vecka = 52,
                PrisVardag = 130,
                PrisVecka = 815,
            });

            modelBuilder.Entity<LogiTyp>().HasData(new LogiTyp()
            {
                LogiTypId = "LGH.I"

            });

            modelBuilder.Entity<LogiTyp>().HasData(new LogiTyp()
            {
                LogiTypId = "LGH.II"

            });

            modelBuilder.Entity<LogiTyp>().HasData(new LogiTyp()
            {
                LogiTypId = "Camp"

            });

            for (int i = 1; i <= 48; i++)
            {

                modelBuilder.Entity<Logi>().HasData(new Logi()
                {
                    LogiId = "Ll" + i,
                    Kvadratmeter = 50,
                    Bäddar = 4,
                    Kök = true,
                    Typen = "LGH.I"

                });

            }

            for (int i = 1; i <= 35; i++)
            {

                modelBuilder.Entity<Logi>().HasData(new Logi()
                {
                    LogiId = "Lll" + i,
                    Kvadratmeter = 70,
                    Bäddar = 6,
                    Kök = true,
                    Typen = "LGH.II"


                });

            }
            for (int i = 1; i <= 35; i++)
            {

                modelBuilder.Entity<Logi>().HasData(new Logi()
                {
                    LogiId = "Camp" + i,
                    Kvadratmeter = 100,
                    Bäddar = 0,
                    Kök = false,
                    Typen = "Camp"

                });

            }
            #endregion Ladda Logi

            #region --------------------------------------------Ladda utrustning    

            //TEST - Tillkommit 
            modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
            {
                UtrustningsId = "P1",
                Status = true,
                Typ = "Alpint",
                Benämning = "Paket"
            });
            modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
            {
                UtrustningsId = "P2",
                Status = true,
                Typ = "Snowboard",
                Benämning = "Paket"
            });
            modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
            {
                UtrustningsId = "P3",
                Status = true,
                Typ = "Längd",
                Benämning = "Paket"
            });

            //Ladda in Alpinskidor
            for (int i = 1; i <= 350; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"AS{+i}",
                    Status = true,
                    Typ = "Alpint",
                    Benämning = "Alpin Skidor"
                });
            }
            //Ladda in Alpinpjäxor
            for (int i = 1; i <= 500; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"AP{+i}",
                    Status = true,
                    Typ = "Alpint",
                    Benämning = "Alpin Pjäxor"
                });
            }
            //Ladda in Alpinstavar
            for (int i = 1; i <= 425; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"ASS{+i}",
                    Status = true,
                    Typ = "Alpint",
                    Benämning = "Alpin Stavar"
                });
            }
            //Ladda in Längdskidor
            for (int i = 1; i <= 150; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"LS{+i}",
                    Status = true,
                    Typ = "Längd",
                    Benämning = "Skidor"
                });
            }
            //Ladda in Längdpjäxor
            for (int i = 1; i <= 200; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"LP{+i}",
                    Status = true,
                    Typ = "Längd",
                    Benämning = "Pjäxor"
                });
            }
            //Ladda in Längdstavar
            for (int i = 1; i <= 175; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"LSS{+i}",
                    Status = true,
                    Typ = "Längd",
                    Benämning = "Stavar"
                });
            }
            //Ladda in Snowboard
            for (int i = 1; i <= 85; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"SB{+i}",
                    Status = true,
                    Typ = "Snowboard",
                    Benämning = "Snowboard"
                });
            }
            //Ladda in Snowboardskor
            for (int i = 1; i <= 90; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"SS{+i}",
                    Status = true,
                    Typ = "Snowboard",
                    Benämning = "Snowboardskor"
                });
            }
            //Ladda in Snöskoter av märket Lynx
            for (int i = 1; i <= 8; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"S{+i}",
                    Status = true,
                    Typ = "Snöskoter",
                    Benämning = "Lynx50"
                });
            }
            //Ladda in Snöskoter av märket Yamaha
            for (int i = 9; i <= 15; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"S{+i}",
                    Status = true,
                    Typ = "Snöskoter",
                    Benämning = "Yamaha Vikning"
                });
            }
            //Ladda in Skoterpulka
            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"NP{+i}",
                    Status = true,
                    Typ = "Snöskoter",
                    Benämning = "Nilapulka"
                });
            }
            //Ladda in Hjälmar
            for (int i = 1; i <= 600; i++)
            {
                modelBuilder.Entity<Utrustning>().HasData(new Utrustning()
                {
                    UtrustningsId = $"H{+i}",
                    Status = true,
                    Typ = "Hjälm",
                    Benämning = "Hjälm"
                });
            }

            modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            {
                Typ = "Alpint"

            });
            modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            {
                Typ = "Snöskoter"

            });
            modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            {
                Typ = "Snowboard"

            });
            modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            {
                Typ = "Längd"

            });
            modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            {
                Typ = "Hjälm"

            });

            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Alpint Skidor"


            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Alpint Pjäxor"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Alpint Stavar"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Längd Skidor"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Längd Pjäxor"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Längd Stavar"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Snowboard"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Snowboard skor"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Snöskoter"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Skoterpulka"

            //});
            //modelBuilder.Entity<UtrustningsTyp>().HasData(new UtrustningsTyp()
            //{
            //    UtrustningsTypId = "Hjälm"

            //});


            #endregion Ladda utrustning

            #region Ladda Grupplektioner
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "G1",
                   LektionsTillfälle = "Måndag - Onsdag",
                   Pris = 400,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Grön,
                   Lärare = 008
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "B1",
                   LektionsTillfälle = "Måndag - Onsdag",
                   Pris = 415,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Blå,
                   Lärare = 007
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "R1",
                   LektionsTillfälle = "Måndag - Onsdag",
                   Pris = 425,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Röd,
                   Lärare = 006
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "S1",
                   LektionsTillfälle = "Måndag - Onsdag",
                   Pris = 455,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Svart,
                   Lärare = 005
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "G2",
                   LektionsTillfälle = "Torsdag & Fredag",
                   Pris = 500,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Grön,
                   Lärare = 004
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "B2",
                   LektionsTillfälle = "Torsdag & Fredag",
                   Pris = 515,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Blå,
                   Lärare = 003
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "R2",
                   LektionsTillfälle = "Torsdag & Fredag",
                   Pris = 525,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Röd,
                   Lärare = 002
               }
               );
            modelBuilder.Entity<GruppLektion>().HasData(
               new GruppLektion()
               {
                   ID = "S2",
                   LektionsTillfälle = "Torsdag & Fredag",
                   Pris = 555,
                   Svårighetsgrad = Entiteter.Enums.Svårighetsgrad.Svart,
                   Lärare = 001
               }
               );

            #endregion Ladda Grupplektioner

            #region Ladda PrivatLektion
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "M1",
                LektionsTillfälle = "Måndag förmiddag",
                Pris = 375,
                Lärare = 009
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "M2",
                LektionsTillfälle = "Måndag Eftermiddag",
                Pris = 375,
                Lärare = 009
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "Ti1",
                LektionsTillfälle = "Tisdag förmiddag",
                Pris = 375,
                Lärare = 010
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "Ti2",
                LektionsTillfälle = "Tisdag Eftermiddag",
                Pris = 375,
                Lärare = 010
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "O1",
                LektionsTillfälle = "Onsdag förmiddag",
                Pris = 375,
                Lärare = 013
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "O2",
                LektionsTillfälle = "Onsdag Eftermiddag",
                Pris = 375,
                Lärare = 013
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "T1",
                LektionsTillfälle = "Torsdag förmiddag",
                Pris = 375,
                Lärare = 014
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "T2",
                LektionsTillfälle = "Torsdag Eftermiddag",
                Pris = 375,
                Lärare = 014
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "F1",
                LektionsTillfälle = "Fredag förmiddag",
                Pris = 375,
                Lärare = 015
            });
            modelBuilder.Entity<PrivatLektion>().HasData(new PrivatLektion()
            {
                ID = "F2",
                LektionsTillfälle = "Fredag Eftermiddag",
                Pris = 375,
                Lärare = 015
            });
            #endregion Ladda PrivatLektion


            // Personal för grupplektion
            #region Ladda Personal
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Bert",
                Efternamn = "Svensson",
                AnstNr = 001,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Åke",
                Efternamn = "Lundgren",
                AnstNr = 002,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Ida",
                Efternamn = "Åslund",
                AnstNr = 003,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Jennifer",
                Efternamn = "Svensson",
                AnstNr = 004,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Angelica",
                Efternamn = "Broberg",
                AnstNr = 005,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Joakim",
                Efternamn = "Sjöberg",
                AnstNr = 006,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Maja",
                Efternamn = "Johnsson",
                AnstNr = 007,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Daniel",
                Efternamn = "Andersson",
                AnstNr = 008,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Isabelle",
                Efternamn = "Lindh",
                AnstNr = 009,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Lisa",
                Efternamn = "Adamsson",
                AnstNr = 010,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Shakira",
                Efternamn = "Shakira",
                AnstNr = 011,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Lundin",
                Efternamn = "Oil",
                AnstNr = 012,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Astra",
                Efternamn = "Zenica",
                AnstNr = 013,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Johnsson",
                Efternamn = "Jonnsson",
                AnstNr = 014,
                Befattning = "Skidlärare",
            });
            modelBuilder.Entity<Personal>().HasData(new Personal()
            {
                Förnamn = "Magdalena",
                Efternamn = "Andersson",
                AnstNr = 015,
                Befattning = "Skidlärare",
            });
            #endregion Ladda Personal
            // Test för att se rabatterat pris

            #region --------------------------------------------Ladda konferenslokal

            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLS1",
                AntalPlatser = 50,
                Storlek = "Stor"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLS2",
                AntalPlatser = 50,
                Storlek = "Stor"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLS3",
                AntalPlatser = 50,
                Storlek = "Stor"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLL1",
                AntalPlatser = 20,
                Storlek = "Liten"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLL2",
                AntalPlatser = 20,
                Storlek = "Liten"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLL3",
                AntalPlatser = 20,
                Storlek = "Liten"
            });

            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLL4",
                AntalPlatser = 20,
                Storlek = "Liten"
            });
            modelBuilder.Entity<Konferenslokal>().HasData(new Konferenslokal()
            {
                KonferensBenämningsId = "KLL5",
                AntalPlatser = 20,
                Storlek = "Liten"
            });





            #endregion

            #region --------------------------------------------Ladda Konferens Prislistor


            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()

            {
                PrisId = 1,
                Vecka = 1,
                VeckoPris = 7500,
                DygnsPris = 1500,
                TimPris = 300,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 2,
                Vecka = 2,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"

            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 3,
                Vecka = 3,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 4,
                Vecka = 4,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 5,
                Vecka = 5,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 6,
                Vecka = 6,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 7,
                Vecka = 7,
                VeckoPris = 7500,
                DygnsPris = 1500,
                TimPris = 300,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 8,
                Vecka = 8,
                VeckoPris = 7500,
                DygnsPris = 1500,
                TimPris = 300,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 9,
                Vecka = 9,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 10,
                Vecka = 10,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 11,
                Vecka = 11,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 12,
                Vecka = 12,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 13,
                Vecka = 13,
                VeckoPris = 7500,
                DygnsPris = 1500,
                TimPris = 300,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 14,
                Vecka = 14,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 15,
                Vecka = 15,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 16,
                Vecka = 16,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 17,
                Vecka = 17,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 18,
                Vecka = 18,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 19,
                Vecka = 19,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 20,
                Vecka = 20,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 21,
                Vecka = 21,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 22,
                Vecka = 22,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 23,
                Vecka = 23,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 24,
                Vecka = 24,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 25,
                Vecka = 25,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 26,
                Vecka = 26,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 27,
                Vecka = 27,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 28,
                Vecka = 28,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 29,
                Vecka = 29,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 30,
                Vecka = 30,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 31,
                Vecka = 31,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 32,
                Vecka = 32,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 33,
                Vecka = 33,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 34,
                Vecka = 34,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 35,
                Vecka = 35,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 36,
                Vecka = 36,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 37,
                Vecka = 37,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 38,
                Vecka = 38,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 39,
                Vecka = 39,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 40,
                Vecka = 40,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 41,
                Vecka = 41,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 42,
                Vecka = 42,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 43,
                Vecka = 43,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 44,
                Vecka = 44,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 45,
                Vecka = 45,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 46,
                Vecka = 46,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 47,
                Vecka = 47,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 48,
                Vecka = 48,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 49,
                Vecka = 49,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 50,
                Vecka = 50,
                VeckoPris = 3500,
                DygnsPris = 800,
                TimPris = 200,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 51,
                Vecka = 51,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 52,
                Vecka = 52,
                VeckoPris = 4500,
                DygnsPris = 1200,
                TimPris = 250,
                Storlek = "Stor"
            });
            //Börjar små

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 53,
                Vecka = 1,
                VeckoPris = 6000,
                DygnsPris = 1150,
                TimPris = 200,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 54,
                Vecka = 2,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 55,
                Vecka = 3,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 56,
                Vecka = 4,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 57,
                Vecka = 5,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 58,
                Vecka = 6,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 59,
                Vecka = 7,
                VeckoPris = 6000,
                DygnsPris = 1150,
                TimPris = 200,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 60,
                Vecka = 8,
                VeckoPris = 6000,
                DygnsPris = 1150,
                TimPris = 200,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 61,
                Vecka = 9,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 62,
                Vecka = 10,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 63,
                Vecka = 11,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 64,
                Vecka = 12,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 65,
                Vecka = 13,
                VeckoPris = 6000,
                DygnsPris = 1150,
                TimPris = 200,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 66,
                Vecka = 14,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 67,
                Vecka = 15,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 68,
                Vecka = 16,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 69,
                Vecka = 17,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 70,
                Vecka = 18,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 71,
                Vecka = 19,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 72,
                Vecka = 20,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 73,
                Vecka = 21,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 74,
                Vecka = 22,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 75,
                Vecka = 23,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 76,
                Vecka = 24,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 77,
                Vecka = 25,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 104,
                Vecka = 26,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 78,
                Vecka = 27,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 79,
                Vecka = 28,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 80,
                Vecka = 29,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 81,
                Vecka = 30,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 82,
                Vecka = 31,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 83,
                Vecka = 32,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 84,
                Vecka = 33,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 85,
                Vecka = 34,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 86,
                Vecka = 35,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 87,
                Vecka = 36,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 88,
                Vecka = 37,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 89,
                Vecka = 38,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 90,
                Vecka = 39,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 91,
                Vecka = 40,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 92,
                Vecka = 41,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 93,
                Vecka = 42,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 94,
                Vecka = 43,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 95,
                Vecka = 44,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });
            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 96,
                Vecka = 45,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 97,
                Vecka = 46,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 98,
                Vecka = 47,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 99,
                Vecka = 48,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 100,
                Vecka = 49,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 101,
                Vecka = 50,
                VeckoPris = 2500,
                DygnsPris = 650,
                TimPris = 115,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 102,
                Vecka = 51,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });

            modelBuilder.Entity<PrisListaKonferens>().HasData(new PrisListaKonferens()
            {
                PrisId = 103,
                Vecka = 52,
                VeckoPris = 3500,
                DygnsPris = 850,
                TimPris = 155,
                Storlek = "Liten"
            });







            #endregion

            #region Ladda PrisUtrustning
            //Ladda Prisutrustningar
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 1,
                TypAvUtrustning = "Alpint",
                BenämningUtrustning = "Paket",
                Dag1 = 180,
                Dag2 = 305,
                Dag3 = 405,
                Dag4 = 495,
                Dag5 = 560
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 2,
                TypAvUtrustning = "Alpint",
                BenämningUtrustning = "Alpin Skidor",
                Dag1 = 130,
                Dag2 = 230,
                Dag3 = 330,
                Dag4 = 395,
                Dag5 = 445
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 3,
                TypAvUtrustning = "Alpint",
                BenämningUtrustning = "Alpin Pjäxor",
                Dag1 = 115,
                Dag2 = 195,
                Dag3 = 255,
                Dag4 = 315,
                Dag5 = 375
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 4,
                TypAvUtrustning = "Alpint",
                BenämningUtrustning = "Alpin Stavar",
                Dag1 = 40,
                Dag2 = 50,
                Dag3 = 60,
                Dag4 = 70,
                Dag5 = 80
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 5,
                TypAvUtrustning = "Längd",
                BenämningUtrustning = "Paket",
                Dag1 = 130,
                Dag2 = 230,
                Dag3 = 320,
                Dag4 = 390,
                Dag5 = 440
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 6,
                TypAvUtrustning = "Längd",
                BenämningUtrustning = "Skidor",
                Dag1 = 100,
                Dag2 = 170,
                Dag3 = 220,
                Dag4 = 270,
                Dag5 = 320
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 7,
                TypAvUtrustning = "Längd",
                BenämningUtrustning = "Pjäxor",
                Dag1 = 80,
                Dag2 = 120,
                Dag3 = 150,
                Dag4 = 170,
                Dag5 = 200
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 8,
                TypAvUtrustning = "Längd",
                BenämningUtrustning = "Stavar",
                Dag1 = 40,
                Dag2 = 50,
                Dag3 = 60,
                Dag4 = 70,
                Dag5 = 80
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 9,
                TypAvUtrustning = "Snowboard",
                BenämningUtrustning = "Paket",
                Dag1 = 250,
                Dag2 = 415,
                Dag3 = 540,
                Dag4 = 655,
                Dag5 = 760
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 10,
                TypAvUtrustning = "Snowboard",
                BenämningUtrustning = "Snowboard",
                Dag1 = 190,
                Dag2 = 335,
                Dag3 = 455,
                Dag4 = 555,
                Dag5 = 625
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 11,
                TypAvUtrustning = "Snowboard",
                BenämningUtrustning = "Snowboardskor",
                Dag1 = 115,
                Dag2 = 195,
                Dag3 = 275,
                Dag4 = 350,
                Dag5 = 395
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 12,
                TypAvUtrustning = "Hjälm",
                BenämningUtrustning = "Hjälm",
                Dag1 = 40,
                Dag2 = 50,
                Dag3 = 60,
                Dag4 = 70,
                Dag5 = 80
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 13,
                TypAvUtrustning = "Snöskoter",
                BenämningUtrustning = "Lynx50",
                Dag1 = 1000,
                Dag2 = 0,
                Dag3 = 2750,
                Dag4 = 0,
                Dag5 = 5950
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 14,
                TypAvUtrustning = "Snöskoter",
                BenämningUtrustning = "Yamaha Vikning",
                Dag1 = 1300,
                Dag2 = 0,
                Dag3 = 3700,
                Dag4 = 0,
                Dag5 = 7250
            });
            modelBuilder.Entity<PrisListaUtrustning>().HasData(new PrisListaUtrustning()
            {
                PrisId = 15,
                TypAvUtrustning = "Snöskoter",
                BenämningUtrustning = "Nilapulka",
                Dag1 = 240,
                Dag2 = 0,
                Dag3 = 640,
                Dag4 = 0,
                Dag5 = 1280
            });


            #endregion


        }
    }



}








