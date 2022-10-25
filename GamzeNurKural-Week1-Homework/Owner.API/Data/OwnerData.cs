using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<Model.Owner> GetAllOwners()
        {
            return new List<Model.Owner>
            {
                new Model.Owner
                {
                    Id=1,
                    FirstName="Gamze",
                    Surname="Kural",
                    Date=DateTime.Now,
                    Description="Description1",
                    Type="Type1"
                },                
                new Model.Owner
                {
                    Id=2,
                    FirstName="Halime",
                    Surname="Kara",
                    Date=DateTime.Now,
                    Description="Description2",
                    Type="Type2"
                },                
                new Model.Owner
                {
                    Id=3,
                    FirstName="Mutlu",
                    Surname="Ekinci",
                    Date=DateTime.Now,
                    Description="Description3",
                    Type="Type3"
                },                
                new Model.Owner
                {
                    Id=4,
                    FirstName="Gökşen",
                    Surname="Göker",
                    Date=DateTime.Now,
                    Description="Description4",
                    Type="Type4"
                },                
                new Model.Owner
                {
                    Id=5,
                    FirstName="Özlem",
                    Surname="Duran",
                    Date=DateTime.Now,
                    Description="Description5",
                    Type="Type5"
                }
            };
        }
    }
}
