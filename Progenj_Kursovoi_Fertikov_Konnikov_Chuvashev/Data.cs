public static class DemoData
{ 
    public static HeroRepository CreateRepository()
    {
        var repo = new HeroRepository();

        repo.AddHero(new Hero
        {
            Name = "Axe",
            Advantage = { ["Phantom Assassin"] = 6, ["Sniper"] = 4, ["Drow Ranger"] = 4 },
            Synergy = { ["Crystal Maiden"] = 3, ["Invoker"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Phantom Assassin",
            Advantage = { ["Sniper"] = 7, ["Drow Ranger"] = 5 },
            Synergy = { ["Magnus"] = 6 }
        });

        repo.AddHero(new Hero
        {
            Name = "Sniper",
            Advantage = { ["Crystal Maiden"] = 2 },
            Synergy = { ["Tidehunter"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Crystal Maiden",
            Advantage = { ["Storm Spirit"] = 3 },
            Synergy = { ["Axe"] = 3, ["Juggernaut"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Juggernaut",
            Advantage = { ["Shadow Shaman"] = 3 },
            Synergy = { ["Crystal Maiden"] = 2, ["Omniknight"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Invoker",
            Advantage = { ["Storm Spirit"] = 4, ["Puck"] = 3 },
            Synergy = { ["Axe"] = 2, ["Tidehunter"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Storm Spirit",
            Advantage = { ["Sniper"] = 5, ["Drow Ranger"] = 4 },
            Synergy = { ["Crystal Maiden"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Puck",
            Advantage = { ["Sniper"] = 4 },
            Synergy = { ["Invoker"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Magnus",
            Advantage = { ["Drow Ranger"] = 5 },
            Synergy = { ["Phantom Assassin"] = 6, ["Juggernaut"] = 4 }
        });

        repo.AddHero(new Hero
        {
            Name = "Tidehunter",
            Advantage = { ["Phantom Assassin"] = 3 },
            Synergy = { ["Invoker"] = 2, ["Sniper"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Drow Ranger",
            Advantage = { ["Crystal Maiden"] = 2 },
            Synergy = { ["Sniper"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Shadow Shaman",
            Advantage = { ["Storm Spirit"] = 4 },
            Synergy = { ["Juggernaut"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Lion",
            Advantage = { ["Storm Spirit"] = 5, ["Puck"] = 4 },
            Synergy = { ["Shadow Shaman"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Omniknight",
            Advantage = { ["Phantom Assassin"] = 3 },
            Synergy = { ["Juggernaut"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Lina",
            Advantage = { ["Drow Ranger"] = 4 },
            Synergy = { ["Crystal Maiden"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Zeus",
            Advantage = { ["Storm Spirit"] = 3, ["Sniper"] = 2 },
            Synergy = { ["Lion"] = 2 }
        });

        repo.AddHero(new Hero
        {
            Name = "Bristleback",
            Advantage = { ["Phantom Assassin"] = 4 },
            Synergy = { ["Omniknight"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Earthshaker",
            Advantage = { ["Phantom Assassin"] = 5, ["Juggernaut"] = 3 },
            Synergy = { ["Magnus"] = 3 }
        });

        repo.AddHero(new Hero
        {
            Name = "Vengeful Spirit",
            Advantage = { ["Sniper"] = 3 },
            Synergy = { ["Drow Ranger"] = 4 }
        });

        repo.AddHero(new Hero
        {
            Name = "Pudge",
            Advantage = { ["Sniper"] = 4 },
            Synergy = { ["Crystal Maiden"] = 2 }
        });

        return repo;
    }
}
