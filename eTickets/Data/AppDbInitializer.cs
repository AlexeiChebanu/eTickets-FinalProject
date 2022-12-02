using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Marvel",
                            Logo = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHcAAAAvCAMAAADuOqUiAAAAclBMVEX////tHCTsAADsABD1nJ7tERvsBhT0iYz1lZjwX2P+9PT5wsP84eLtFyD71dbsAAf97Oz6y8z2o6Xzen33qKr/+vr72tvycnXzg4X4ubruIyv70NHwS07uMDjwU1f85ubvQ0jvPEHxZmn3srTuKjL0j5EYvJw2AAAEtElEQVRYhcWY3YKyLBCAEYTMIi3Tfmyzcrv/W/z4mcFBd98+jnZOFIF5AIdhBpb9jbA/5EoBovy3UJauKOJqFWp1Rj/ILK4molCHplx5P+Re3k6zPEExb2y5Kg4H3+BtVasVVBbNkwv74UwaZ7LJl3Lmx4OV40MTrnozFKsn41ss7rkthto2M934EMqsLrjM+MYXBu46k+ogHepYS8pdhQZuPKrG4sao0k8WVU+jckNZc5H719JxZfkDd/eJezLf9VcoWq58Tf1fcs5lrOBnePvWUecUbm4WWq4jLvkLrBBLLlvd4OUura3497ZN4jpQXKwuU/+x+oHLcEHsYimYfF3TFh+5nQWNEZf3tP9P3AF+6cGshjj4930at7ULuYu5xFBqMt/tgn+xrcG4j8AdtlYun7jsS2d8Gqrh6iv9U1cduAV/zrZMR1ajASV37qT6xF1LraeS4aKheLlN3FxIGS0mqw1XIK+MQB+5K0VBlnuiqo1PmriZaCJue9X6iq+J3LFCiwQuGErtV9uYDuHqLNot7CY17KmSJ3J7Lo4RFwyl24UPE3du2y+pGlSTyK0rvo+5XvXe7+Jhxp1M30oh0GeOVSKXXYk5W67yCka/CqX8F3esODiZs0rl3jgpbDieCjn89af+aZ3hN/ecd6gfuUpb+cxtHhEXnXWzxo7UrnBvw7QHjtvoqktUdzPy+Og3WE73zYZj3RoM9a3oPsKOR88vjTo/f55Fx+HH89eg8ohbgXU/QKP5hZPfwE3K1jDN5wPmP+N+9M9maJuIC6dC+81b0PCDn2zDb4XFuqRza+p0DdcXa1zeQSC3nwY4BjOGs/otUrjE+ZTIBcvZhm19XZ6D7FkBr4Aj9KVSuN3UdofcB7xUeCrfltycYyx0gcE9ZQp3GzzVsEEu/LCxEjClZsHteYj9dv4/tyZOTrDnIXjmPnAL/1IIPJeKObe3wTi4ibIFTOC+vr+MfP+bG461Y+CCwZzC8biZcxsbc1eRw7RhSoK/GjAwZOfA3WF7DFC7OXfjYvsL/WTDzgT/XAfXfNujTvR7JlYBn4Tc/cm/lDaJECTYddFBGhePIo1cwRaig98Ac7DBPA3ufVqRxIWQtcTNunksuXf0kxxYRz5LE1walcSFGfSBGwVXXk7gE/MKfMpgDYuGeFsT7aZx4ZAdkXspltwcuQKNzmVrxKBdFpnEBYM+B25kpvAtcDGoeYvYoA9kvj5+rpDri3LOhdB5HbhxHOOkC1yMCXoeG/RZTdyuN7Ibcad0OyOdTaQiLpw+18CF3qtT05ywFYk3fLWJm2kS6fLCX/wkqFNzruOVHLl7OKK0klJBsIwZpuFiMzN+YtCtzYN/ORd+4fogvQ9cOItrd/2g4nTIxjmwuDYhmwza2Xca14fdYxRDM59+LoJWu84hOzC1Xdw6iasf9nlWM+7Fc2PjtnFsyMJMWB2y5mP1f7lvHLbOvBaaawPCQPLFx5DtCnId4S+josxpZldvz9X3vLCykmbqRZGbkTQFkfzubp2wmb+SOlgXINf+YsvsHP3ASzB/R/WmGs5VPtdn7+v0dB1nb9sycmNHb9l09NF5Hjn11HHr6NpOZVFXnf3t/eRfyH/RNkebZcJhKQAAAABJRU5ErkJggg==",
                            Description = "This is the description of Marvel Studio"
                        },
                        new Cinema()
                        {
                            Name = "DC",
                            Logo = "data:image/png;base64,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",
                            Description = "This is the description of DC Studio"
                        },
                        new Cinema()
                        {
                            Name = "Paramount",
                            Logo = "data:image/png;base64,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",
                            Description = "This is the description of Paramount Pictures Studio"
                        },
                        new Cinema()
                        {
                            Name = "Walt Disney",
                            Logo = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAF4AAACACAMAAAC1OC4DAAAAaVBMVEX///8AAADOzs7U1NTn5+etra3Kysrk5OT5+fnq6urGxsa+vr7u7u709PRdXV3CwsK0tLSVlZV0dHSenp45OTmmpqbe3t5jY2OIiIhra2spKSl6enodHR1LS0szMzNUVFQVFRVDQ0MNDQ02JiIKAAAJn0lEQVRogeWaaZOsrA6ARdx3cAN3/f8/8k1A7c1uPTM9H27d1KmpPtPwCCEJSRzDMAyH/ImYhhaH5PbXJb/DR8bXxbrDW9/Hu/+feM88H/Ob1ffsgin8fPUsCf4QH2dXRv0cb/8pPsr/FF+xP8X/te7LP8X7X1dOVJlBGIapQ13PqNqv4T3TFpwzVoYOpRWFh5R5O4fh+XbP8QEb25LGz78OeyM2yyyrfoPPxqT0DyeWzQrIwg/B7RPerPv3rsmW/WOcBu4/4+1OvAmJ/hMef+Ucb+EdPp/eLxxnuHx5AlJ6GW83nwJWaOChTC+WWb0e8xHeLD67DD46I2Q8WOyzGbzi4zY5tpVdcrDSbE7k0Xe+9xnvDKexKofHZ3V77LbeA/8Zz/rzGzQHHYfCfqvBOFLH84qPE3EKhyVQIxyLfn431hs5P8BH1hC+mfEgwjQ4ZqfLS6RYpSZD+ooPhyPTfZVGGCHi6zffZ6KxqfeCH9659pPMzPAQ/94G9jh1j/8c/HbxSAI7ADzstXqnnwP8xduKYU3Q6MogOHGRH+ADQgxjArwDaj7R5w/wJuJR94F2gS/jnTu8+BY+2p09uMPLE1O+jA/XdYZGuuHBdepv4bdhQuFNxIOLJ86X8KlWDm0MAWrJVrcaT6LIZXym8dVko02qoADXynyShl/G59E6vpVAFojnkVecpOGX8WLDEzbpcn5gWTydBPDLeK79012ScWsXFMy2+We3vYxPVsN0po40Sje157T18tkyr+Itkm/DMFQiviscqazzC3hOFh0cy35q2kSSviDEl8p1f4+nsFrMDNKYhwXxI0FKkRPXJs3ngH8N7/Zz38+gBxFIupDM74gQJekHMnwDHyZZ4ARghO3QVKQQ4UiYKDme8K/y+1V8yaVM4HBFK0NSAxy8K09b8h3dRw0vgyoZio4ENE2h+gmomfGWSbInU/lRdLuI70bhuDyRHWmrmrdSytLJByHHWzZSHp3CRXzb5qKECkuSGZI89Y+xAnXfx5YOdoc54TW8Vc9AYmYkMQkRsQfZsU0WTBeSaHJx3d5hwnyIf3F0N8Ssj+HqIXu0eQ8/4Vbp0XdDYuaw/opcxb/2sfylA5LMs56IrXQwZRu1CQQ2InpM+MlRcDvEvxibD5RSh0m24ass9BwG8XMuxgCjxpHyD/HpAb7rNT7f8DFuR+acVA43Ma+aLuJfG03+rSecKXyPqSZjpg36bzmrVMp8EDyP8E+NpvgBj7kTwVQE8B48yRFeDDVnSd177Ww+cFgZ9g/4NgI80y3n1KY6O4ZQ03CMpBKNyDdCyyZ3m87M93j5EKdiUHdEcrdSItw9t+9hFRCSJXpUPpOaJMU+aYMe4C0d2jeBfLtoCNc3bEM83eiHEXLAY0J8buSSDQQ9+hyfw+zY2xN30DTcTEyuuvcMZaEdKA17ItEsjbw1oqnTWeE2yX+H9+CWI2W1t8ogtuAvuKY3hjesbxWExlkhmVmFY8ge1PZjPsBjeLFDvuPnGr0p0fjeMwjrIUtLYZd5HHsqHSQJHjfZd8xJF73BG0ir2m4bmpNWr3tARAMPA13VZBx6MhTFTCZ7GEP97M0iqPbuI7wXoZb9YbcjdYuLZRYCn9tA9irYKOqW1qTxq7y0DfDnWimH7ivaGhov+KhZz3Ar/tFkRJ6UIoBDXpRRBjxUiVThGbQsI8C3vT4YLbgZeYJfV680I0DDJZqo3QLXTnkmyChyqJ+NiFeopW5zaSTh6TX8WPfytnqHqn1CHAvUpQfFfNdtq5+aQfmH7/eg6PJuTfq0Z+8QL1Y8fByKVH+2KxXN9Tyle72IQdaZb/XNuL1Uw3Bi6WH18epXAye0WtmoSNpQJw1K8iKJYKUsTUq1ThefUu0X2nRe8fU6sVu6G6UgTddNDXmRZVmmaeqaZtH/B+2tn9rP+DfSt7OezT+P06bzih8/zxLGKPt2HKLqBH+se28+mcbksMyE8+Rk3HiIj4eTaYT5kRex9mzYsWFG09k0daXGZ4vXmf8L3j2btt55p8NU/PwBvryIt47w7HSasrjwHJ8+4f0LdvkPq+dPeOpbllucTsNhVtSfjkt8y6d3+D+RDR9DXPq+mCedyP8N8ayQiZbzVpRB5J2P/zcR3f15NNL+6t9ElGTkUPqVTCTzemkk2cGpuIzzs97lgUzzLfePaJmovSziqUMcrVdI9q9bg3TlQd9Rqi+thwfQDpsUSv59A89i6eNg+2Mh2GVmQbrSDcmVdyBnEqumXLH1CmpiQu5Qg2IiculV8/kDVNKjlxotbaDjFGRav/NFsdflFYauEWn+NEzqArXqky7LmcTdrUpSF0CBJ4yHbZt2fdaeOxVKbv0FfXMMvs7EUYrfmk36aHnY7oZc2yUDb7rk8H3PPzlCeasElMCRqvoSnvkmGvWX3vuvIp7wKr1+XLVX0fuXSuLhPNY1pG/sC3yfZXbm3A4AbuAOBleDmhm0azLEcT8ICbAiNeLQFgl+1eDMTJlv/HhSbnmfIMnVBDGhzLFogh/mXaIFm+zxuZB8sfv0ocApiaHKrLtWQ/aSY69v+mpVGrTgYip1nTnLS/U6heqaYVb1RrCWNgWEkgKvWRW5tnN3NbyHYCNZu6Ukih+qDyN4bU6a+74T+jVTq8TjSndYicYAiCLcmtsuaVhqaU2rg/SwGNR1QKU0McOG8ZhrkecZXU9lwG8CpTwDO4XqrvOwcpXqpetaJBpii4P9nZ2sYcZVOUUBivBEP63aZ6qQzHpguhiatuSnR19plb9Xhr/haX/Db72ZdlVOoJRTEBUtLGpSB5uDHLFBgJnbhBQYNC1qQYJQ9PISG5Jb90msLdV5x9NE+ttjugh23HlrcFha1yJTRHFTMN5qoBzxsOcSWbEyBSzhYL3xdIsAiXoRjz2Rp4COuuGqGeIZTRY5dTcNGV0IFpkVbg2iaYvHsu26JoVSjTUr+9x/C9/HDSGP7bRIj13x2C2uAhsOrvFKpTxlj6WBhxwI2ctYF/PSRdO4911BBrtqyGNTMuy0GjUe9FGsV65asKsXBN/ceRvdPz96bdBArXqPj8J+tRLDUHiDblm0UF6lqpC5oHvF3aXakJWDPfdmY4Z1b9HmWeBgDFFV8KQNtey0IgOeJHWpZq7WrGKR6kdOIjbWTgcpyoMIaz0Xh8v+lzond6yf54EaGoM6R9c9Dt/gtfNeRjT1DxJCdJO3f2cAAST0LBradma6P0oKQDfT20VFrfhdjoyl/eHrgu+I9Uk3v5d0i+N/I0zfMX8l/LEN/W2Rf6r65zzs65J193XHf8FwjY4rHv6HAAAAAElFTkSuQmCC",
                            Description = "This is the description of Walt Disney Pictures Studio"
                        },
                        new Cinema()
                        {
                            Name = "Universal Pictures",
                            Logo = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAE0AAAArCAMAAAAKevXFAAAAe1BMVEUAAAD////8/PxsbGxpaWn19fUmJiYJCQm2trYEBARMTEwpKSmcnJwSEhJUVFQiIiIYGBiTk5MwMDDr6+t2dnaAgIDLy8thYWHT09M5OTmtra09PT2MjIzk5ORYWFhDQ0N5eXmlpaW9vb2ZmZna2trm5uYWFhZHR0e7u7tsus8WAAADaklEQVRIia2W2WKjOgyGJYMx+746rAkJ8/5POLKhLaTttOSc/4YEyx+yLEsG+LfSUc4cWVb6ffCD6U+y2pnZrTQn7s+I7FqJ11mBj4hdA6K2izDk0q3me/8iy8kzVGKGzXBuQZBfUW7b0UswiQfl23uXD+dhcbkjsc4wr+seiCYvT6/Wue5ZoZmnYaEHgqkPO/MkrG3fYXN6GGpaiWw5ReujYmPxxHsaiygG9zOpFw9wQ5waN5Wfvej9TNbTCRrtWrF+P3/2DGDESRjl5/ffSWXWgjf98/NoU5oQ9L+nKS3X/GejV+SsemXqI7RgaXthX0P1d2J9v+0uQMmzbi4L4jaylP2XfKuh4Izy4XXZhXYMTUgoZjaWNBbzuyAaI3GAesUW4HH17B5kMXKVylYbbjRESxlGKWIWQ7jRQkTK2paOZ6/c0ipxjC1JnxkxC3OaAmqi+uqA8jMN7Y3mg9ORQcCzQNEMw0g1LXecG02vkLURhJRCF3I8Ug/7neZttDutIkRD08Cg94ZKk1Avz9A0rQQElU6cVD5KnLHd09hKs1JMJmS3N5rIcKqx0bQkSS6axvlKiSSjuEUQs7nBu/M1zam1F62iERN1TIjmvMUtjzm5BlYA1o2RUznWBccFmh2NYjJj7JFdyj9oKo7uSrOVAkWjALAU+vtoPa5kta7d39E6slkwA0XTId9ocMVZPdwt32JNo1XYWyjRTLE0igkzp8E/G41WdGcqifTJTLoKKqnLYWpcdD67WouAoaJVNEUbQGhz7ArH187XGDaqppZ5kIKwqYq1DgR0Ck5Ix1KXuSExvFnl89SoGh9537XJoL5nJL7p8Uzbm1pNCl8V0R07ynbNpjzM/u0i4t3v/KPZFOIbm39L7PpK8U6TB5sT1XL4CND0BusOPX44cyH5aJhbFZLGAZY2J2B0zTrS2uNwfLI99xsuoNPN2dPkaDpb1otkjQzlvP8Uo2U6fy0sSh2pmj/lglPIVxpOlSXES8rjW1d3mRcU/eE3y8l3vom+7k7t5tGRKyvbPlVhcqLBkFltvubYJq9VLYCpCo7Z9MKt8lnxUOVjbrref3Lrf1JA+WVZ4gJWDGksYjE4C23FJYg8iKL4AtSrYsf6ZRUZK3VvW4qgkGBEfRtPAR2GIH/kJthGWAnfXXxhfHnT/wv/UzT8hMfsTQAAAABJRU5ErkJggg==",
                            Description = "This is the description of Universal Pictures"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tom Cruise",
                            Bio = "This is the bio of Tom Cruise",
                            ProfilePictureURL = "https://resizing.flixster.com/GaISa_nUOWmxO5flBqNZ9uyIkKM=/218x280/v2/https://flxt.tmsimg.com/assets/378_v9_bd.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Scarlett Johansson",
                            Bio = "This is the bio of Scarlett Johansson",
                            ProfilePictureURL = "https://resizing.flixster.com/_WMBACkzcg4y17_9aiGUawoF-ew=/218x280/v2/https://resizing.flixster.com/KLxcE36ZNENLC_23WoChmpOkvMA=/ems.ZW1zLXByZC1hc3NldHMvY2VsZWJyaXRpZXMvMzkzZTdmN2UtNDlhYi00NzllLWJlOTktZDVkYWU2ZWFmYzgwLmpwZw==",
                        },
                        new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "This is the bio of Angelina Jolie",
                            ProfilePictureURL = "https://resizing.flixster.com/okYEdM_7tzPMdURLta7JRbsNfiI=/218x280/v2/https://flxt.tmsimg.com/assets/4950_v9_bb.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Brad Pitt",
                            Bio = "This is the bio of Brad Pitt",
                            ProfilePictureURL = "https://resizing.flixster.com/fTmkkK2g0AApV8vnSJHYszbolZ0=/218x280/v2/https://flxt.tmsimg.com/assets/1366_v9_bc.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Robert Downey Jr.",
                            Bio = "This is the bio of Robert Downey Jr.",
                            ProfilePictureURL = "https://resizing.flixster.com/q7BloXhsHUePl46wQ1RILXs5sKU=/218x280/v2/https://resizing.flixster.com/OOPw6FXLl1dvZXrlE73jckDTzpc=/ems.cHJkLWVtcy1hc3NldHMvY2VsZWJyaXRpZXMvYTUxYzhlNTctMzg2OS00YWJjLWEwYmEtOWY1ZjE0Njg2ZWVlLmpwZw==",
                            }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "This is the bio of Steven Spielberg",
                            ProfilePictureURL = "https://static.thetoptens.com/img/lists/49401lg.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Kevin Feige",
                            Bio = "This is the bio of Kevin Feige",
                            ProfilePictureURL = "https://static.thetoptens.com/img/lists/27611lg.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Kathleen Kennedy",
                            Bio = "This is the bio of Kathleen Kennedy",
                            ProfilePictureURL = "https://static.thetoptens.com/img/lists/220349.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Harvey Weinstein",
                            Bio = "This is the bio of Harvey Weinstein",
                            ProfilePictureURL = "https://static.thetoptens.com/img/lists/91337lg.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Tim Burton",
                            Bio = "This is the bio of Tim Burton",
                            ProfilePictureURL = "https://static.thetoptens.com/img/lists/26978lg.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "14 PEAKS: NOTHING IS IMPOSSIBLE",
                            Description = "14 PEAKS: NOTHING IS IMPOSSIBLE movie",
                            Price = 39.50,
                            ImageURL = "https://resizing.flixster.com/nI4bd7d8wOftYgh7qiVUwmd0kGM=/206x305/v2/https://resizing.flixster.com/pcnei1ZnVpDlvCh4U6CnyVkjLho=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzL2ZhMDkzNjU5LTAyZjYtNDMzNS05ODlmLWFhMTJkZjMxMTQyMy5qcGc=",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Top Gun: Maverick",
                            Description = "The Top Gun: Maverick movie",
                            Price = 29.50,
                            ImageURL = "https://resizing.flixster.com/UuyjwlbRE17UP6ot-ehuA_UXdrw=/206x305/v2/https://resizing.flixster.com/TIM4kfHTVZrfpF0tYt9LIU69A5s=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzU1OWIwMWQwLWYyZDItNDk4Yi04MDIxLWI3OTJlNDI1NjA3NS5qcGc=",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Barbarian",
                            Description = "This is the Barbarian movie",
                            Price = 39.50,
                            ImageURL = "https://resizing.flixster.com/6eT6yv_PEO3CJC1CrOCx9bxf3UA=/206x305/v2/https://resizing.flixster.com/Ym6ucXdlZjGTqRWEMVr0r3H16Ro=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzA3ZGY2MjgxLTI1NjEtNGFhMC1iYzQ0LTllOGFhYTczNzYxNy5qcGc=",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Black Widow",
                            Description = "This is the Black Widow movie",
                            Price = 39.50,
                            ImageURL = "https://resizing.flixster.com/EyahmtqNmxs6zwn-bK1q9fmfiyA=/206x305/v2/https://resizing.flixster.com/UqanC4hHIFolYIKoZ020-YmubCQ=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzRkMWJjZjI2LWE0MDktNDczZC05ZmNiLTIzMTQ0NTE5MGJiMC5qcGc=",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Minions: The Rise of Gru",
                            Description = "The Minions: The Rise of Gru movie",
                            Price = 39.50,
                            ImageURL = "https://resizing.flixster.com/5M85GItiHLI3ZvsJjlXAOWAlzMs=/206x305/v2/https://resizing.flixster.com/s2eQM6eCyFOAYE_jOckLuj7op84=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzBkOGQzNDU5LWQ0YjgtNDczNi1hNmE1LWI1ZWFjY2QxZTNlYS5qcGc=",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "All Quiet on the Western Front",
                            Description = "The All Quiet on the Western Front movie",
                            Price = 39.50,
                            ImageURL = "https://resizing.flixster.com/r8C2ibQO8krwKNCi3v1nV2SWX3A=/206x305/v2/https://resizing.flixster.com/Tv-nj_XzcvU5GZthFm-0xrSvvjo=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzljM2U3Mjk3LWExNzgtNGE2NS05OTMxLWVlZmU1NzNlZWM5MS5qcGc=",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
