using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIStarWar.Migrations
{
    public partial class AddFilmsPeoplePlanetsSpeciesStarshipsVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FilmId = table.Column<int>(type: "INTEGER", nullable: false),
                    Producer = table.Column<string>(type: "TEXT", nullable: true),
                    EpisodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningCrawl = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PeopleId = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    EyeColor = table.Column<string>(type: "TEXT", nullable: true),
                    HairColor = table.Column<string>(type: "TEXT", nullable: true),
                    Mass = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SkinColor = table.Column<string>(type: "TEXT", nullable: true),
                    Homeworld = table.Column<string>(type: "TEXT", nullable: true),
                    BirthYear = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false),
                    RotationPeriod = table.Column<string>(type: "TEXT", nullable: true),
                    Diameter = table.Column<string>(type: "TEXT", nullable: true),
                    Terrain = table.Column<string>(type: "TEXT", nullable: true),
                    OrbitalPeriod = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SurfaceWater = table.Column<string>(type: "TEXT", nullable: true),
                    Gravity = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<string>(type: "TEXT", nullable: true),
                    Climate = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SpecieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Classification = table.Column<string>(type: "TEXT", nullable: true),
                    EyeColors = table.Column<string>(type: "TEXT", nullable: true),
                    HairColors = table.Column<string>(type: "TEXT", nullable: true),
                    Designation = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SkinColors = table.Column<string>(type: "TEXT", nullable: true),
                    Homeworld = table.Column<string>(type: "TEXT", nullable: true),
                    AverageLifespan = table.Column<string>(type: "TEXT", nullable: true),
                    AverageHeight = table.Column<string>(type: "TEXT", nullable: true),
                    Language = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StarshipId = table.Column<int>(type: "INTEGER", nullable: false),
                    CostInCredits = table.Column<string>(type: "TEXT", nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(type: "TEXT", nullable: true),
                    StarshipClass = table.Column<string>(type: "TEXT", nullable: true),
                    Crew = table.Column<string>(type: "TEXT", nullable: true),
                    HyperdriveRating = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    CargoCapacity = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Length = table.Column<string>(type: "TEXT", nullable: true),
                    MGLT = table.Column<string>(type: "TEXT", nullable: true),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: true),
                    Consumables = table.Column<string>(type: "TEXT", nullable: true),
                    Passengers = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehicleClass = table.Column<string>(type: "TEXT", nullable: true),
                    CostInCredits = table.Column<string>(type: "TEXT", nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(type: "TEXT", nullable: true),
                    Crew = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    CargoCapacity = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Length = table.Column<string>(type: "TEXT", nullable: true),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: true),
                    Consumables = table.Column<string>(type: "TEXT", nullable: true),
                    Passengers = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Speaker = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("04009b4d-35cd-488b-a0fb-39a220bd2ffe"), new DateTime(2014, 12, 10, 14, 23, 31, 880, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 19, 49, 45, 256, DateTimeKind.Utc), 4, 1, "It is a period of civil war.\r\nRebel spaceships, striking\r\nfrom a hidden base, have won\r\ntheir first victory against\r\nthe evil Galactic Empire.\r\n\r\nDuring the battle, Rebel\r\nspies managed to steal secret\r\nplans to the Empire's\r\nultimate weapon, the DEATH\r\nSTAR, an armored space\r\nstation with enough power\r\nto destroy an entire planet.\r\n\r\nPursued by the Empire's\r\nsinister agents, Princess\r\nLeia races home aboard her\r\nstarship, custodian of the\r\nstolen plans that can save her\r\npeople and restore\r\nfreedom to the galaxy....", "Gary Kurtz, Rick McCallum", "A New Hope", "https://swapi.dev/api/films/1/" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("c20783ca-68d3-48af-88be-8df06408e5ca"), new DateTime(2014, 12, 12, 11, 26, 24, 656, DateTimeKind.Utc), "Irvin Kershner", new DateTime(2014, 12, 15, 13, 7, 53, 386, DateTimeKind.Utc), 5, 2, "It is a dark time for the\r\nRebellion. Although the Death\r\nStar has been destroyed,\r\nImperial troops have driven the\r\nRebel forces from their hidden\r\nbase and pursued them across\r\nthe galaxy.\r\n\r\nEvading the dreaded Imperial\r\nStarfleet, a group of freedom\r\nfighters led by Luke Skywalker\r\nhas established a new secret\r\nbase on the remote ice world\r\nof Hoth.\r\n\r\nThe evil lord Darth Vader,\r\nobsessed with finding young\r\nSkywalker, has dispatched\r\nthousands of remote probes into\r\nthe far reaches of space....", "Gary Kurtz, Rick McCallum", "The Empire Strikes Back", "https://swapi.dev/api/films/2/" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("cc5cd68c-2287-4048-ae3e-37fccccbae53"), new DateTime(2014, 12, 18, 10, 39, 33, 255, DateTimeKind.Utc), "Richard Marquand", new DateTime(2014, 12, 20, 9, 48, 37, 462, DateTimeKind.Utc), 6, 3, "Luke Skywalker has returned to\r\nhis home planet of Tatooine in\r\nan attempt to rescue his\r\nfriend Han Solo from the\r\nclutches of the vile gangster\r\nJabba the Hutt.\r\n\r\nLittle does Luke know that the\r\nGALACTIC EMPIRE has secretly\r\nbegun construction on a new\r\narmored space station even\r\nmore powerful than the first\r\ndreaded Death Star.\r\n\r\nWhen completed, this ultimate\r\nweapon will spell certain doom\r\nfor the small band of rebels\r\nstruggling to restore freedom\r\nto the galaxy...", "Howard G. Kazanjian, George Lucas, Rick McCallum", "Return of the Jedi", "https://swapi.dev/api/films/3/" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("465ebd3d-86eb-4ea4-a634-adfb8147f4dc"), new DateTime(2014, 12, 19, 16, 52, 55, 740, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 10, 54, 7, 216, DateTimeKind.Utc), 1, 4, "Turmoil has engulfed the\r\nGalactic Republic. The taxation\r\nof trade routes to outlying star\r\nsystems is in dispute.\r\n\r\nHoping to resolve the matter\r\nwith a blockade of deadly\r\nbattleships, the greedy Trade\r\nFederation has stopped all\r\nshipping to the small planet\r\nof Naboo.\r\n\r\nWhile the Congress of the\r\nRepublic endlessly debates\r\nthis alarming chain of events,\r\nthe Supreme Chancellor has\r\nsecretly dispatched two Jedi\r\nKnights, the guardians of\r\npeace and justice in the\r\ngalaxy, to settle the conflict....", "Rick McCallum", "The Phantom Menace", "https://swapi.dev/api/films/4/" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("6c4797fa-c2a5-4cb4-b55d-009620baae33"), new DateTime(2014, 12, 20, 10, 57, 57, 886, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 20, 18, 48, 516, DateTimeKind.Utc), 2, 5, "There is unrest in the Galactic\r\nSenate. Several thousand solar\r\nsystems have declared their\r\nintentions to leave the Republic.\r\n\r\nThis separatist movement,\r\nunder the leadership of the\r\nmysterious Count Dooku, has\r\nmade it difficult for the limited\r\nnumber of Jedi Knights to maintain \r\npeace and order in the galaxy.\r\n\r\nSenator Amidala, the former\r\nQueen of Naboo, is returning\r\nto the Galactic Senate to vote\r\non the critical issue of creating\r\nan ARMY OF THE REPUBLIC\r\nto assist the overwhelmed\r\nJedi....", "Rick McCallum", "Attack of the Clones", "https://swapi.dev/api/films/5/" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Created", "Director", "Edited", "EpisodeId", "FilmId", "OpeningCrawl", "Producer", "Title", "Url" },
                values: new object[] { new Guid("e2f690e3-e9b3-4e5e-a25b-d6833a356426"), new DateTime(2014, 12, 20, 18, 49, 38, 403, DateTimeKind.Utc), "George Lucas", new DateTime(2014, 12, 20, 20, 47, 52, 73, DateTimeKind.Utc), 3, 6, "War! The Republic is crumbling\r\nunder attacks by the ruthless\r\nSith Lord, Count Dooku.\r\nThere are heroes on both sides.\r\nEvil is everywhere.\r\n\r\nIn a stunning move, the\r\nfiendish droid leader, General\r\nGrievous, has swept into the\r\nRepublic capital and kidnapped\r\nChancellor Palpatine, leader of\r\nthe Galactic Senate.\r\n\r\nAs the Separatist Droid Army\r\nattempts to flee the besieged\r\ncapital with their valuable\r\nhostage, two Jedi Knights lead a\r\ndesperate mission to rescue the\r\ncaptive Chancellor....", "Rick McCallum", "Revenge of the Sith", "https://swapi.dev/api/films/6/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("3cf2f0f9-2b98-4ffc-ac88-fe2d5443b72c"), "24BBY", new DateTime(2014, 12, 10, 15, 59, 50, 509, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 323, DateTimeKind.Utc), "brown", "male", "black", "183", "https://swapi.dev/api/planets/1/", "84", "Biggs Darklighter", 9, "light", "https://swapi.dev/api/people/9/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("cb464128-84ed-4cc6-9faa-b5e2f4855009"), "unknown", new DateTime(2014, 12, 10, 15, 57, 50, 959, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 321, DateTimeKind.Utc), "red", "n/a", "n/a", "97", "https://swapi.dev/api/planets/1/", "32", "R5-D4", 8, "white, red", "https://swapi.dev/api/people/8/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("69335ade-3332-4dd2-9b67-28088c182668"), "47BBY", new DateTime(2014, 12, 10, 15, 53, 41, 121, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 319, DateTimeKind.Utc), "blue", "female", "brown", "165", "https://swapi.dev/api/planets/1/", "75", "Beru Whitesun lars", 7, "light", "https://swapi.dev/api/people/7/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("e98297ef-6935-4f28-8179-2ef93aeda458"), "52BBY", new DateTime(2014, 12, 10, 15, 52, 14, 24, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 317, DateTimeKind.Utc), "blue", "male", "brown, grey", "178", "https://swapi.dev/api/planets/1/", "120", "Owen Lars", 6, "light", "https://swapi.dev/api/people/6/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("22d4dff7-cab7-4837-ad60-c661c05af345"), "57BBY", new DateTime(2014, 12, 10, 16, 16, 29, 192, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 325, DateTimeKind.Utc), "blue-gray", "male", "auburn, white", "182", "https://swapi.dev/api/planets/20/", "77", "Obi-Wan Kenobi", 10, "fair", "https://swapi.dev/api/people/10/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("3fa33eca-6095-4abe-b86a-409688aec876"), "41.9BBY", new DateTime(2014, 12, 10, 15, 18, 20, 704, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 313, DateTimeKind.Utc), "yellow", "male", "none", "202", "https://swapi.dev/api/planets/1/", "136", "Darth Vader", 4, "white", "https://swapi.dev/api/people/4/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("35563a5d-f8e1-4e48-b543-84bafae1f929"), "33BBY", new DateTime(2014, 12, 10, 15, 11, 50, 376, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 311, DateTimeKind.Utc), "red", "n/a", "n/a", "96", "https://swapi.dev/api/planets/8/", "32", "R2-D2", 3, "white, blue", "https://swapi.dev/api/people/3/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("c8cbdfa1-f3d6-4489-9c00-90f2b8c1c3ad"), "112BBY", new DateTime(2014, 12, 10, 15, 10, 51, 357, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 309, DateTimeKind.Utc), "yellow", "n/a", "n/a", "167", "https://swapi.dev/api/planets/1/", "75", "C-3PO", 2, "gold", "https://swapi.dev/api/people/2/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("7b19eace-13bb-403c-ab0a-70ff2bc441e3"), "19BBY", new DateTime(2014, 12, 9, 13, 50, 51, 644, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 56, 891, DateTimeKind.Utc), "blue", "male", "blond", "172", "https://swapi.dev/api/planets/1/", "77", "Luke Skywalker", 1, "fair", "https://swapi.dev/api/people/1/" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "Homeworld", "Mass", "Name", "PeopleId", "SkinColor", "Url" },
                values: new object[] { new Guid("9a80b755-9732-4e26-ad75-7fdae5624c95"), "19BBY", new DateTime(2014, 12, 10, 15, 20, 9, 791, DateTimeKind.Utc), new DateTime(2014, 12, 20, 21, 17, 50, 315, DateTimeKind.Utc), "brown", "female", "brown", "150", "https://swapi.dev/api/planets/2/", "49", "Leia Organa", 5, "light", "https://swapi.dev/api/people/5/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("d8914c66-5ad5-41a0-8743-f89e5c0ba572"), "temperate", new DateTime(2014, 12, 10, 12, 45, 6, 577, DateTimeKind.Utc), "19720", new DateTime(2014, 12, 20, 20, 58, 18, 434, DateTimeKind.Utc), "1 standard", "Kamino", "463", 10, "3", "27", "100", "ocean", "https://swapi.dev/api/planets/10/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("091dc879-cb26-4db7-ac7d-24571246f8b3"), "temperate", new DateTime(2014, 12, 10, 11, 54, 13, 921, DateTimeKind.Utc), "12240", new DateTime(2014, 12, 20, 20, 58, 18, 432, DateTimeKind.Utc), "1 standard", "Coruscant", "368", 9, "3", "24", "unknown", "cityscape, mountains", "https://swapi.dev/api/planets/9/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("aff71f2d-2cf6-4b86-8246-c649ab6c37d9"), "temperate", new DateTime(2014, 12, 10, 11, 52, 31, 66, DateTimeKind.Utc), "12120", new DateTime(2014, 12, 20, 20, 58, 18, 430, DateTimeKind.Utc), "1 standard", "Naboo", "312", 8, "11", "26", "12", "grassy hills, swamps, forests, mountains", "https://swapi.dev/api/planets/8/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("3d85e8da-4d4a-4926-a1c7-16ea50f52802"), "temperate", new DateTime(2014, 12, 10, 11, 50, 29, 349, DateTimeKind.Utc), "4900", new DateTime(2014, 12, 20, 20, 58, 18, 429, DateTimeKind.Utc), "0.85 standard", "Endor", "402", 7, "1", "18", "8", "forests, mountains, lakes", "https://swapi.dev/api/planets/7/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("3206e29e-f660-4bc1-ac9f-7bb88ec32d87"), "temperate", new DateTime(2014, 12, 10, 11, 43, 55, 240, DateTimeKind.Utc), "118000", new DateTime(2014, 12, 20, 20, 58, 18, 427, DateTimeKind.Utc), "1.5 (surface), 1 standard (Cloud City)", "Bespin", "5110", 6, "1", "12", "0", "gas giant", "https://swapi.dev/api/planets/6/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("24e8e561-4958-4ce7-b3ef-bdb0637b59c5"), "murky", new DateTime(2014, 12, 10, 11, 42, 22, 590, DateTimeKind.Utc), "8900", new DateTime(2014, 12, 20, 20, 58, 18, 425, DateTimeKind.Utc), "N/A", "Dagobah", "341", 5, "0", "23", "8", "swamp, jungles", "https://swapi.dev/api/planets/5/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("87b36881-0241-4984-a9b4-87f6f3a4548d"), "temperate, tropical", new DateTime(2014, 12, 10, 11, 37, 19, 144, DateTimeKind.Utc), "10200", new DateTime(2014, 12, 20, 20, 58, 18, 421, DateTimeKind.Utc), "1 standard", "Yavin IV", "4818", 3, "0", "24", "8", "jungle, rainforests", "https://swapi.dev/api/planets/3/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("04c4b689-f1ee-4d4a-bd6c-fd6e13a2b15f"), "temperate", new DateTime(2014, 12, 10, 11, 35, 48, 479, DateTimeKind.Utc), "12500", new DateTime(2014, 12, 20, 20, 58, 18, 420, DateTimeKind.Utc), "1 standard", "Alderaan", "364", 2, "3", "24", "40", "grasslands, mountains", "https://swapi.dev/api/planets/2/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("64f607a5-0d6b-4890-bc5f-531569810a4a"), "arid", new DateTime(2014, 12, 9, 13, 50, 49, 641, DateTimeKind.Utc), "10465", new DateTime(2014, 12, 20, 20, 58, 18, 411, DateTimeKind.Utc), "1 standard", "Tatooine", "304", 1, "10", "23", "1", "desert", "https://swapi.dev/api/planets/1/" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "PlanetId", "Population", "RotationPeriod", "SurfaceWater", "Terrain", "Url" },
                values: new object[] { new Guid("426524f3-9a72-4bb1-a54a-3637155de384"), "frozen", new DateTime(2014, 12, 10, 11, 39, 13, 934, DateTimeKind.Utc), "7200", new DateTime(2014, 12, 20, 20, 58, 18, 423, DateTimeKind.Utc), "1.1 standard", "Hoth", "549", 4, "0", "23", "100", "tundra, ice caves, mountain ranges", "https://swapi.dev/api/planets/4/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("8f552b7b-c3ab-4b5c-b70d-fad1bb40f945"), "200", "unknown", null, new DateTime(2014, 12, 15, 13, 7, 47, 704, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 151, DateTimeKind.Utc), "yellow, orange", "none", "https://swapi.dev/api/planets/29/", "Dosh", "Trandoshan", "brown, green", 7, "https://swapi.dev/api/species/7/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("a88f335c-7a68-4b90-9978-3752137603ad"), "180", "unknown", null, new DateTime(2014, 12, 18, 11, 26, 20, 103, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 157, DateTimeKind.Utc), "black", "none", "https://swapi.dev/api/planets/33/", "Sullutese", "Sullustan", "pale", 10, "https://swapi.dev/api/species/10/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("79f5566d-3cd9-4fd7-92dd-41ec5f95bef1"), "100", "unknown", null, new DateTime(2014, 12, 18, 11, 22, 0, 285, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 155, DateTimeKind.Utc), "orange, brown", "white, brown, black", "https://swapi.dev/api/planets/7/", "Ewokese", "Ewok", "brown", 9, "https://swapi.dev/api/species/9/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("acfb00ac-3e4b-4056-b313-de589f619bfa"), "160", "unknown", null, new DateTime(2014, 12, 18, 11, 9, 52, 263, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 153, DateTimeKind.Utc), "yellow", "none", "https://swapi.dev/api/planets/31/", "Mon Calamarian", "Mon Calamari", "red, blue, brown, magenta", 8, "https://swapi.dev/api/species/8/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("1abcf174-225b-4cc9-94f7-1d00f00c26e3"), "66", "900", null, new DateTime(2014, 12, 15, 12, 27, 22, 877, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 148, DateTimeKind.Utc), "brown, green, yellow", "brown, white", "https://swapi.dev/api/planets/28/", "Galactic basic", "Yoda's species", "green, yellow", 6, "https://swapi.dev/api/species/6/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("ef5eca59-eb49-4dba-9497-ccf48a1f093a"), "n/a", "indefinite", null, new DateTime(2014, 12, 10, 15, 16, 16, 259, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 139, DateTimeKind.Utc), "n/a", "n/a", null, "n/a", "Droid", "n/a", 2, "https://swapi.dev/api/species/2/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("39685f34-5d0c-4a4c-b185-d7e544dc535b"), "170", "unknown", null, new DateTime(2014, 12, 10, 17, 5, 26, 471, DateTimeKind.Utc), "reptilian", new DateTime(2014, 12, 20, 21, 36, 42, 144, DateTimeKind.Utc), "black", "n/a", "https://swapi.dev/api/planets/23/", "Galatic Basic", "Rodian", "green, blue", 4, "https://swapi.dev/api/species/4/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("b334dbd6-5508-46f7-ab7e-4dd032c84235"), "210", "400", null, new DateTime(2014, 12, 10, 16, 44, 31, 486, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 142, DateTimeKind.Utc), "blue, green, yellow, brown, golden, red", "black, brown", "https://swapi.dev/api/planets/14/", "Shyriiwook", "Wookie", "gray", 3, "https://swapi.dev/api/species/3/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("794d3556-5fcc-4196-973a-7e46b37264fe"), "180", "120", null, new DateTime(2014, 12, 10, 13, 52, 11, 567, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 136, DateTimeKind.Utc), "brown, blue, green, hazel, grey, amber", "blonde, brown, black, red", "https://swapi.dev/api/planets/9/", "Galactic Basic", "Human", "caucasian, black, asian, hispanic", 1, "https://swapi.dev/api/species/1/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "AverageHeight", "AverageLifespan", "Classification", "Created", "Designation", "Edited", "EyeColors", "HairColors", "Homeworld", "Language", "Name", "SkinColors", "SpecieId", "Url" },
                values: new object[] { new Guid("aed3f0c1-b178-435b-9656-f65c6f2756a9"), "300", "1000", null, new DateTime(2014, 12, 10, 17, 12, 50, 410, DateTimeKind.Utc), "sentient", new DateTime(2014, 12, 20, 21, 36, 42, 146, DateTimeKind.Utc), "yellow, red", "n/a", "https://swapi.dev/api/planets/24/", "Huttese", "Hutt", "green, brown, tan", 5, "https://swapi.dev/api/species/5/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("8c2f9aed-020b-41de-b1cc-2c68720e1b06"), "19000000", "6 months", "unknown", new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc), "6", new DateTime(2014, 12, 20, 21, 23, 49, 895, DateTimeKind.Utc), "4.0", "90", "20", "Gallofree Yards, Inc.", "650", "GR-75 medium transport", "Rebel transport", "90", "Medium transport", 17, "https://swapi.dev/api/starships/17/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("a37a5f5b-8996-4532-a85a-56714d57e7a8"), "250000000", "6 years", "1143350000", new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Utc), "279,144", new DateTime(2014, 12, 20, 21, 23, 49, 893, DateTimeKind.Utc), "2.0", "19000", "40", "Kuat Drive Yards, Fondor Shipyards", "n/a", "Executor-class star dreadnought", "Executor", "38000", "Star dreadnought", 15, "https://swapi.dev/api/starships/15/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("d5564327-00b2-4bdf-a2ea-baed1ddb382c"), "110", "1 week", "149999", new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 886, DateTimeKind.Utc), "1.0", "12.5", "100", "Incom Corporation", "1050", "T-65 X-wing", "X-wing", "0", "Starfighter", 12, "https://swapi.dev/api/starships/12/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("7b251f1e-c565-4483-9db4-91ad118ab727"), "110", "1 week", "134999", new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Utc), "2", new DateTime(2014, 12, 20, 21, 23, 49, 883, DateTimeKind.Utc), "1.0", "14", "80", "Koensayr Manufacturing", "1000km", "BTL Y-wing", "Y-wing", "0", "assault starfighter", 11, "https://swapi.dev/api/starships/11/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("c3cd8690-b649-40d4-8fba-469cda2628e0"), "150", "5 days", "unknown", new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 889, DateTimeKind.Utc), "1.0", "9.2", "105", "Sienar Fleet Systems", "1200", "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0", "Starfighter", 13, "https://swapi.dev/api/starships/13/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("4b753e1c-d3fa-48a3-bda9-08637b82ece1"), "1000000000000", "3 years", "1000000000000", new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Utc), "342,953", new DateTime(2014, 12, 20, 21, 26, 24, 783, DateTimeKind.Utc), "4.0", "120000", "10", "Imperial Department of Military Research, Sienar Fleet Systems", "n/a", "DS-1 Orbital Battle Station", "Death Star", "843,342", "Deep Space Mobile Battlestation", 9, "https://swapi.dev/api/starships/9/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("cca376fc-13fa-485c-8199-e3118efaaac7"), "180000", "1 month", "240000", new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Utc), "5", new DateTime(2014, 12, 20, 21, 23, 49, 873, DateTimeKind.Utc), "1.0", "38", "70", "Sienar Fleet Systems, Cyngus Spaceworks", "1000", "Sentinel-class landing craft", "Sentinel-class landing craft", "75", "landing craft", 5, "https://swapi.dev/api/starships/5/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("ae9f1917-adf1-45c1-a5ba-8c13679512ec"), "36000000", "2 years", "150000000", new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Utc), "47,060", new DateTime(2014, 12, 20, 21, 23, 49, 870, DateTimeKind.Utc), "2.0", "1,600", "60", "Kuat Drive Yards", "975", "Imperial I-class Star Destroyer", "Star Destroyer", "n/a", "Star Destroyer", 3, "https://swapi.dev/api/starships/3/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("e1bd0355-d501-424b-b67f-b6bac57d5898"), "3000000", "1 year", "3500000", new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Utc), "30-165", new DateTime(2014, 12, 20, 21, 23, 49, 867, DateTimeKind.Utc), "2.0", "150", "60", "Corellian Engineering Corporation", "950", "CR90 corvette", "CR90 corvette", "600", "corvette", 2, "https://swapi.dev/api/starships/2/" });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass", "StarshipId", "Url" },
                values: new object[] { new Guid("c12fddc7-b974-4a86-bf6f-234bc31c2d96"), "100000", "2 months", "100000", new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Utc), "4", new DateTime(2014, 12, 20, 21, 23, 49, 880, DateTimeKind.Utc), "0.5", "34.37", "75", "Corellian Engineering Corporation", "1050", "YT-1300 light freighter", "Millennium Falcon", "6", "Light freighter", 10, "https://swapi.dev/api/starships/10/" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("4467ae42-965a-43d9-95a9-f90d03151b5d"), "10", "1 day", "75000", new DateTime(2014, 12, 15, 12, 58, 50, 530, DateTimeKind.Utc), "2", new DateTime(2014, 12, 20, 21, 30, 21, 681, DateTimeKind.Utc), "7", "Bespin Motors", "1500", "Storm IV Twin-Pod", "Storm IV Twin-Pod cloud car", "0", "https://swapi.dev/api/vehicles/20/", "repulsorcraft", 20 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("fa0075ee-d0e2-4112-afdb-31f419aa8104"), "50000", "2 months", "150000", new DateTime(2014, 12, 10, 15, 36, 25, 724, DateTimeKind.Utc), "46", new DateTime(2014, 12, 20, 21, 30, 21, 661, DateTimeKind.Utc), "36.8 ", "Corellia Mining Corporation", "30", "Digger Crawler", "Sand Crawler", "30", "https://swapi.dev/api/vehicles/4/", "wheeled", 4 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("44eac0e1-abee-4ed0-99d0-063a11dffb6a"), "50", "0", "14500", new DateTime(2014, 12, 10, 16, 1, 52, 434, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 30, 21, 665, DateTimeKind.Utc), "10.4 ", "Incom Corporation", "1200", "T-16 skyhopper", "T-16 skyhopper", "1", "https://swapi.dev/api/vehicles/6/", "repulsorcraft", 6 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("c70bb224-ad6b-4e32-946d-c5e2c356c6b7"), "5", "unknown", "10550", new DateTime(2014, 12, 10, 16, 13, 52, 586, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 30, 21, 668, DateTimeKind.Utc), "3.4 ", "SoroSuub Corporation", "250", "X-34 landspeeder", "X-34 landspeeder", "1", "https://swapi.dev/api/vehicles/7/", "repulsorcraft", 7 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("f2bf8936-0c3e-4592-ba31-2a334d905477"), "65", "2 days", "unknown", new DateTime(2014, 12, 10, 16, 33, 52, 860, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 30, 21, 670, DateTimeKind.Utc), "6.4", "Sienar Fleet Systems", "1200", "Twin Ion Engine/Ln Starfighter", "TIE/LN starfighter", "0", "https://swapi.dev/api/vehicles/8/", "starfighter", 8 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("ecfa9a40-a1ab-466b-88a0-ad671a4e30fe"), "10", "none", "unknown", new DateTime(2014, 12, 15, 12, 22, 12, 0, DateTimeKind.Utc), "2", new DateTime(2014, 12, 20, 21, 30, 21, 672, DateTimeKind.Utc), "4.5", "Incom corporation", "650", "t-47 airspeeder", "Snowspeeder", "0", "https://swapi.dev/api/vehicles/14/", "airspeeder", 14 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("f9eb7ff5-9812-4ab2-8b7a-b938dcedbe06"), "none", "2 days", "unknown", new DateTime(2014, 12, 15, 12, 33, 15, 838, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 30, 21, 675, DateTimeKind.Utc), "7.8", "Sienar Fleet Systems", "850", "TIE/sa bomber", "TIE bomber", "0", "https://swapi.dev/api/vehicles/16/", "space/planetary bomber", 16 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("656abdfc-2a3f-47f4-9913-2a644ab51d3d"), "1000", "unknown", "unknown", new DateTime(2014, 12, 15, 12, 38, 25, 937, DateTimeKind.Utc), "5", new DateTime(2014, 12, 20, 21, 30, 21, 677, DateTimeKind.Utc), "20", "Kuat Drive Yards, Imperial Department of Military Research", "60", "All Terrain Armored Transport", "AT-AT", "40", "https://swapi.dev/api/vehicles/18/", "assault walker", 18 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("000af4e1-2dba-437c-acc6-b1cf803bcc0a"), "200", "none", "unknown", new DateTime(2014, 12, 15, 12, 46, 42, 384, DateTimeKind.Utc), "2", new DateTime(2014, 12, 20, 21, 30, 21, 679, DateTimeKind.Utc), "2", "Kuat Drive Yards, Imperial Department of Military Research", "90", "All Terrain Scout Transport", "AT-ST", "0", "https://swapi.dev/api/vehicles/19/", "walker", 19 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "Url", "VehicleClass", "VehicleId" },
                values: new object[] { new Guid("d02f4743-5140-466e-a27f-6bec3a005474"), "2000000", "Live food tanks", "285000", new DateTime(2014, 12, 18, 10, 44, 14, 217, DateTimeKind.Utc), "26", new DateTime(2014, 12, 20, 21, 30, 21, 684, DateTimeKind.Utc), "30", "Ubrikkian Industries Custom Vehicle Division", "100", "Modified Luxury Sail Barge", "Sail barge", "500", "https://swapi.dev/api/vehicles/24/", "sail barge", 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Peoples");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Workshops");
        }
    }
}
