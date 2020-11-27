using web.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MKNZContext context)
        {
            context.Database.EnsureCreated();
         /*   
            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Nick="tef",UserSurname="Sedmak",UserName="Tevž",Member=true,Reservations={0},Music=Music.metal},
            new User{Nick="ajej",UserSurname="Cek",UserName="Rok",Member=true,Reservations={0, 1},Music=Music.metal},
            new User{Nick="Manky",UserSurname="Mankovč",UserName="Matej",Member=false,Reservations={1},Music=Music.rock}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var bands = new Band[]
            {
            new Band{EventID=1,BandName="Cryptic Blik Creation",Music=Music.metal,Events={1}},
            new Band{EventID=1,BandName="Kontejner",Music.metal,Events={1}},
            new Band{EventID=2,BandName="Stolice",Music.pop,Events={2}}


            };
            foreach (Band c in bands)
            {
                context.Bands.Add(c);
            }
            context.SaveChanges();

            var events = new Event[]
            {
            new Event{BandID=1,EventName="Shod Huje",EDate=DateTime.Parse("2020-9-1"),Bands={0, 1}},
            new Event{BandID=2,EventName="Festival Šembije",EDate=DateTime.Parse("2020-9-10"),Bands={2}}
            };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }

            var medias = new Media[]
            {
            new Media{EventID=0,MediaDate=DateTime.Parse("2020-9-1"),Event=0,Url="https://www.rocker.si/wp-content/uploads/2020/10/concert-crowd-music-fanclub-hand-using-cellphone-taking-video-record-live-stream_41418-3380-626x381-1.jpg",ImageName="Koncert0"},
            new Media{EventID=1,MediaDate=DateTime.Parse("2020-9-10"),Event=1,Url="https://www.siddharta.net/storage/images/2005/4/041210-ljubljana_2602_4.jpg",ImageName="Koncert1"}
            };
            foreach (Media m in medias)
            {
                context.Media.Add(m);
            }

            var reservations = new Reservation[]
            {
            new Reservation{ReservationDate=DateTime.Parse("2000-8-8"),Event=0,Users={0, 1}},
            new Media{EventID=1,MediaDate=DateTime.Parse("2020-9-10"),Event=1,Users={1, 2}}
            };
            foreach (Reservation r in reservations)
            {
                context.Reservation.Add(r);
            }
            */
            var roles = new IdentityRole[] {
                new IdentityRole{Id="1", Name="Administrator"},
                new IdentityRole{Id="2", Name="Manager"},
                new IdentityRole{Id="3", Name="Obiskovalec"}
            };

            foreach (IdentityRole r in roles)
            {
                context.Roles.Add(r);
            }

            var user = new ApplicationUser
            {
                FirstName = "Bob",
                LastName = "Dilon",
                Nickname = "dylan09",
                Email = "bob@example.com",
                NormalizedEmail = "XXXX@EXAMPLE.COM",
                UserName = "bob@example.com",
                NormalizedUserName = "bob@example.com",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };


            if (!context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user,"Testni123!");
                user.PasswordHash = hashed;
                context.Users.Add(user);
                
            }
            
            context.SaveChanges();
            

            var UserRoles = new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>{RoleId = roles[0].Id, UserId=user.Id},
                new IdentityUserRole<string>{RoleId = roles[1].Id, UserId=user.Id},
            };

            foreach (IdentityUserRole<string> r in UserRoles)
            {
                context.UserRoles.Add(r);
            }

            context.SaveChanges();
        }
    }
}