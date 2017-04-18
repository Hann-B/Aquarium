using Aquarium.DataContext;
using Aquarium.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //connection with Db context
            var db = new AquariumContext();
            
            //Create Ocean OR Update Ocean
            db.Oceans.AddOrUpdate(
                a => a.Name,
                new Oceans
                {
                    Name = "Pacific Ocean",
                    AvgTemp = 86
                },
                new Oceans
                {
                    Name = "Atlantic Ocean",
                    AvgTemp = 57
                },
                new Oceans
                {
                    Name = "Indian Ocean",
                    AvgTemp = 77
                },
                new Oceans
                {
                    Name = "Artic Ocean",
                    AvgTemp = 31
                },
                new Oceans
                {
                    Name="Southern Ocean",
                    AvgTemp=20
                });

            //Read Oceans
            var allOceans = db.Oceans.ToList();

            ////Delete Ocean
            //var oceanToDelete = db.Oceans.First(f => f.Name == "Southern Ocean");
            //db.Oceans.Remove(oceanToDelete);

            //Save to DB
            db.SaveChanges();

            //Create Aquarium OR Update Aquarium
            db.Aquariums.AddOrUpdate(
                a => a.Name,
                new Aquariums
                {
                    Name = "Georgia Aquarium",
                    City = "Georgia"
                },
                new Aquariums
                {
                    Name = "Montery Bay Aquarium",
                    City = "Montery"
                },
                new Aquariums
                {
                    Name = "Aquarium of Genoa",
                    City = "Genova"
                },
                new Aquariums
                {
                    Name = "New England Aquarium",
                    City = "Boston"
                },
                new Aquariums
                {
                    Name = "The Florida Aquarium",
                    City = "Channelside"
                },
                new Aquariums
                {
                    Name="Shanghai Ocean Aquarium",
                    City="Shanghai Shi"
                });

            //Read Aquariums
            var allAquariums = db.Aquariums.ToString();

            ////Delete Aquarium
            //var aquariumToDelete = db.Aquariums.First(f => f.Name == "Shanghai Ocean Aquarium");
            //db.Aquariums.Remove(aquariumToDelete);

            //Save to DB
            db.SaveChanges();

            //Add AquaticLife OR Update AquaticLife
            db.MarineLife.AddOrUpdate(
                a => a.Name,
                new MarineLife
                {
                    Type = "Fish",
                    Color = "Yellow",
                    Name = "Angelfish",
                    IsInQuarenteen = false
                },
                new MarineLife
                {
                    Type="Fish",
                    Color="Orange",
                    Name="Clown Fish",
                    IsInQuarenteen=false
                },
                new MarineLife
                {
                    Type="Fish",
                    Color="Green",
                    Name="Electric Eel",
                    IsInQuarenteen=false
                },
                new MarineLife
                {
                    Type="Fish",
                    Color="Grey",
                    Name="Piranha",
                    IsInQuarenteen=true
                },
                new MarineLife
                {
                    Type="Fish",
                    Color="Blue",
                    Name="Tang",
                    IsInQuarenteen=false
                },
                new MarineLife
                {
                    Type="Mammal",
                    Color="Black",
                    Name="Killer Whale",
                    IsInQuarenteen=false
                },
                new MarineLife
                {
                    Type="Mammal",
                    Color="White",
                    Name="Polar Bear",
                    IsInQuarenteen=false
                },
                new MarineLife
                {
                    Type="Mammal",
                    Color="Brown",
                    Name="Fur Seal",
                    IsInQuarenteen=false
                });

            //Read MarineLife
            var allMarineLife = db.MarineLife.ToList();

            //Delete Aquarium
            //var marineLifeToDelete = db.MarineLife.First(f => f.Name == "Clown Fish");
            //db.MarineLife.Remove(marineLifeToDelete);

            //Save to DB
            db.SaveChanges();

            //Add MarineLife to GA Aquarium
            var ga = db.Aquariums.First(f => f.Name == "Georgia Aquarium");
            var ang = db.MarineLife.First(f => f.Name == "Angelfish");
            //ga.MarineLife.Add(ang);
            var clo = db.MarineLife.First(f => f.Name == "Clown Fish");
            //ga.MarineLife.Add(clo);
            var eel = db.MarineLife.First(f => f.Name == "Electric Eel");
            //ga.MarineLife.Add(eel);

            //Add MarineLife to Montery Bay Aquarium
            var mb = db.Aquariums.First(f => f.Name == "Montery Bay Aquarium");
            var fur = db.MarineLife.First(f => f.Name == "Fur Seal");
            //mb.MarineLife.Add(fur);
            var tan = db.MarineLife.First(f => f.Name == "Tang");
            //mb.MarineLife.Add(tan);

            //Add MarineLife to Aquarium of Genoa
            var ge = db.Aquariums.First(f => f.Name == "Aquarium of Genoa");
            var pir = db.MarineLife.First(f => f.Name == "Piranha");
            //ge.MarineLife.Add(pir);
            //ge.MarineLife.Add(clo);

            //Add MarineLife to New England Aquarium
            var ne = db.Aquariums.First(f => f.Name == "New England Aquarium");
            //ge.MarineLife.Add(pir);
            //ge.MarineLife.Add(ang);
            //ge.MarineLife.Add(eel);

            //Add MarineLife to The Florida Aquarium
            var fl = db.Aquariums.First(f => f.Name == "The Florida Aquarium");
            var kil = db.MarineLife.First(f => f.Name == "Killer Whale");
            //fl.MarineLife.Add(kil);
            //fl.MarineLife.Add(tan);

            //db.SaveChanges();

            //Add MarineLife to Atlantic Ocean
            var atl = db.Oceans.First(f => f.Name == "Atlantic Ocean");
            //atl.MarineLife.Add(ang);
            //atl.MarineLife.Add(clo);
            //atl.MarineLife.Add(eel);

            //Add MarineLife to Arctic Ocean
            var arc = db.Oceans.First(f => f.Name == "Artic Ocean");
            var pol = db.MarineLife.First(f => f.Name == "Polar Bear");
            //arc.MarineLife.Add(fur);
            //arc.MarineLife.Add(pol);
            //arc.MarineLife.Add(kil);

            //Add MarineLife to Indian Ocean
            var ind = db.Oceans.First(f => f.Name == "Indian Ocean");
            //ind.MarineLife.Add(clo);
            //ind.MarineLife.Add(ang);

            //Add MarineLife to Pacific Ocean
            var pac = db.Oceans.First(f => f.Name == "Pacific Ocean");
            //pac.MarineLife.Add(clo);
            //pac.MarineLife.Add(ang);

            //db.SaveChanges();

            //Query that given an Aquarium Name, What AquaticLife is there
            var marineLifeInFlAquarium = fl.MarineLife.ToList();


            //Query given an Ocean, What Aquariums have fish from that ocean

            //Query that Returns Only the Distinct Cities that have aquariums

            //Query Display Count: How many spp live in each Ocean

            //Query Dispaly Count:How many spp live in each Ocean, Order: Most to least

            //given: Aquarium, What Oceans are represented in that aquarium.
        }
    }
}