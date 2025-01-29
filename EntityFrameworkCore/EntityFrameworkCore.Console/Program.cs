using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

class Program {



    public static async Task Main()
    {


        // get all teams
        // await GetAllTeam();


        //  get, find by id , get first record 
        //  await GetOneTeam();


        // filtered team method 
        // await FilteredTeam();


        // filtered by user input filter condition 
        // await FilteredTeamByAcceptingInput();


        // Filter search term with like card  e.g LIKE "%FC%;
        // await SearchTeam();


        // filter query 
        // await GetAllTeamsQuerySyntax();


        // Count 
        // SELECT COUNT(*) FROM Teams
        // await CountTotalTeams();


        //  Count 
        //  SELECT COUNT(*) FROM Teams Where Name = 'Spur';
        //  await CountTotalWithCondition();


        // Count method condition
        // SELECT COUNT(*) FROM Teams Where Name LIKE '%MAN%';
        // await CountTotalWithLIKECondition();


        // Aggregate Method
        // await Aggregation();


        // Aggregate and group by 
        // await GroupByAndAggregationAsync();


        // Order by method 
        // OrderTeam();


        // Order by max or min value method 
        // await OrderByMaxOrMin();


        // for pagination => skip and next 
        // await SkipAndNext();

        // Select and Projection - more precise queries 
        // DTOs 
        //  await SelectAndProjection();

        // IQueryable vs List type
        await Filter();


        Console.ReadKey();

    }

    

    public static async Task GetAllTeam()
    {
        FootballLeagueDbContext context = new FootballLeagueDbContext(); // var context = new FootballLeagueDbContext();

        //select all teams
        // sql queries => SELECT * FROM Teams
        //LINQ 
         var teams = await context.Teams.ToListAsync(); //  List<Team> teams = context.Teams.ToList();


        //foreach (var team in teams)
        //{
        //    Console.WriteLine(team.Name);
        //}
       
    }

   
    public static async Task GetOneTeam()
    {

       
        var context = new FootballLeagueDbContext();

        //select  a single team record - First one in the list
        // var teamsOne = await context.Coaches.FirstAsync();
        // var teamsOne = await context.Teams.FirstOrDefaultAsync();


        //select a single record - First one in the list that meets a condition
        // var teamsTwo = await context.Teams.FirstAsync(x => x.TeamId == 1);
        // var teamsTwo = await context.Teams.FirstOrDefaultAsync(x=> x.TeamId == 1);


        //Selecting a single record - only one record should be returned
        // var teamThree =  await context.Teams.SingleOrDefaultAsync();
        // var teamThreee = await context.Teams.SingleOrDefaultAsync(x => x.TeamId == 1);


        //Selecting based on id 
        var teamForth = await context.Teams.FindAsync(2);

        if (teamForth != null) {

            Console.WriteLine(teamForth.Name + $":with id of {teamForth.TeamId}");


        }
        else
        {
            Console.WriteLine("No Team with the id selected");
            
        }

    }


    public static async Task FilteredTeam()
    {
        var context = new FootballLeagueDbContext();
        var fileredTeams = await context.Teams.Where(x => x.Name == "Manchester United" && x.TeamId == 1).ToListAsync();

        foreach ( var item in fileredTeams)
        {
            Console.WriteLine(item.Name);
        }

    }

    public static async Task FilteredTeamByAcceptingInput()
    {
        Console.WriteLine("The filtered desired value:");
        var textInput = Console.ReadLine();

        //db instantiation 
        var context = new FootballLeagueDbContext();
        var filteredResult = await context.Teams.Where(x => x.Name == textInput).ToListAsync();
        foreach (var item in filteredResult) 
        {
            Console.WriteLine($"The team name is {item.Name} and id is " + item.TeamId);
        
        
        }


    }

    public static async Task SearchTeam()
    {
        Console.WriteLine("Please enter your team name : ");
        var searchTerm = Console.ReadLine();

        var context = new FootballLeagueDbContext();

        // var itemTeams =  await context.Teams.Where(x=> x.Name.Contains(searchTeam)).ToListAsync();
        //SELECT * FROM Teams WHERE Name LIKE "%FC%;
        var itemTerms = await context.Teams.Where(x => EF.Functions.Like(x.Name, $"%{searchTerm}%")).ToListAsync();

        foreach (var item in itemTerms)
        {
            Console.WriteLine(item.Name);
        }



    }


    public static async Task GetAllTeamsQuerySyntax()
    {
        var context = new FootballLeagueDbContext();

        var teams = await (from team in context.Teams
                           where EF.Functions.Like(team.Name,"%Manchester%")
                           select team
                          
                           )
            .ToListAsync();

        foreach( var item in teams)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static async Task CountTotalTeams()
    {

        var context = new FootballLeagueDbContext();

        var totalOfNOTeam = await context.Teams.CountAsync();

        Console.WriteLine("The total of teams overall: " + totalOfNOTeam);

    }

    public static async Task CountTotalWithCondition()
    {

        var context = new FootballLeagueDbContext();

        var totalOfNOTeamWithWhereCondition = await context.Teams.CountAsync(x=> x.Name == "Spur FC");
        Console.WriteLine("The total of teams with condition: " + totalOfNOTeamWithWhereCondition);

    }

    public static async Task CountTotalWithLIKECondition()
    {

        var context = new FootballLeagueDbContext();

        var totalOfNOTeamWithWhereCondition = await context.Teams.CountAsync(x => EF.Functions.Like(x.Name,"%MAN%"));
        Console.WriteLine("The total of teams with condition: " + totalOfNOTeamWithWhereCondition);

    }

    public static async Task Aggregation()
    {
        var context = new FootballLeagueDbContext();

        var max = await context.Teams.MaxAsync(x => x.TeamId);
        var min = await context.Teams.MinAsync(x => x.TeamId);
        var avg = await context.Teams.AverageAsync(x => x.TeamId);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(avg);
    }

    public static async Task GroupByAndAggregationAsync()
    {
        var context = new FootballLeagueDbContext();

        var groupItem = await context.Teams
        .Where(x => EF.Functions.Like(x.Name, "%s%"))  // Filter teams whose name contains "s" // where clause
        .GroupBy(y => new { y.CreatedDate.Date }).ToListAsync();     // Group by creation date
                                                                     // .Where(group => group.Max(c => c.TeamId) > 1).ToListAsync(); // having clause


        // .Where(x => x.Count > 0 ); // having clause



        foreach (var group in groupItem)
        {
            Console.WriteLine(group.Key);
            Console.WriteLine(group.Sum(z => z.TeamId));
            foreach (var item in group)
            {
                Console.WriteLine(item.Name);
            }

        }
    }

    public static void OrderTeam()
    {
        var context = new FootballLeagueDbContext();

       var ascOrderedTeam =  context.Teams.OrderBy(x=>x.TeamId);
        foreach(var item in ascOrderedTeam)
        {
            Console.WriteLine(item.Name);
        }


        var descOrderedTeam = context.Teams.OrderByDescending(x=>x.TeamId);
        foreach (var item in descOrderedTeam)
        {
            Console.WriteLine(item.Name);
        }


     
    }

    public static async Task OrderByMaxOrMin()
    {
        var context = new FootballLeagueDbContext();
        // Getting the record with a maximum value
        // var maxBy = context.Teams.MaxBy(x => x.TeamId);
        var maxByAscOrder = await context.Teams.OrderBy(x => x.TeamId)
            .FirstOrDefaultAsync();

       // Getting the record with a minimun value
       // var minBy = context.Teams.MinBy(x => x.TeamId);
       var minByDescOrder = await context.Teams.OrderByDescending(x => x.TeamId) 
            .FirstOrDefaultAsync();



    }


    public static async Task SkipAndNext()
    {

        var context = new FootballLeagueDbContext();
        int recordCount = 3;
        int page = 0;
        bool next = true;

        while (next) 
        {
            var teams = await context.Teams.Skip(page * recordCount).Take(recordCount).ToListAsync();

            foreach (var team in teams) 
            {
                Console.WriteLine(team.Name);
            }

            Console.WriteLine("Enter 'true' for the next set of records. 'false' to exit");
            next = Convert.ToBoolean(Console.ReadLine());


           
        
        
        if(!next) break;
        page++;
        
        }

    }

    class TeamInfoDTOS
    {
        public required string Name { get; set; }
        public DateTime Created { get; set; }
    }
        public static async Task SelectAndProjection()
        {
            var context = new FootballLeagueDbContext();
            var teamItem = await context.Teams
                .AsNoTracking() // no Tracking - EF core tracks objects that are returned by queries. This is less useful in disconnected application like APIs and web app 
                .Select(x => new TeamInfoDTOS { Name = x.Name, Created = x.CreatedDate })
                .ToListAsync();

        foreach( var team in teamItem)
        {
            Console.WriteLine($"{team.Name} - {team.Created}");
        }

          
        }

    //IQueryable vs List type

    public static async Task Filter()
    {
        var context = new FootballLeagueDbContext();

        Console.WriteLine("Enter '1' for team with id 1 or '2' for team that contain id 'FC'");
        var option = Convert.ToInt32(Console.ReadLine());

        List<Team> teamAsList = new List<Team>();


        //After executing to ToListAsync, the records are loaded in memory. Any operation is then done in memory
        teamAsList = await context.Teams.ToListAsync();
        if (option == 1)
        {
            teamAsList = context.Teams.Where(x => x.TeamId == 1).ToList();

        } else if (option == 2) 
        {

            teamAsList = context.Teams.Where(x => x.Name.Contains("FC")).ToList();

        }

        foreach (var t in teamAsList) {


            Console.WriteLine(t.Name);
        
        
        }

        var teamsAsQueryable = context.Teams.AsQueryable();

        if(option == 1)
        {
            teamsAsQueryable = context.Teams.Where(z => z.TeamId == 1);
        }
        else if(option == 2)
        {

            teamsAsQueryable = context.Teams.Where(z => z.Name.Contains("FC"));

        }




        //Actaul Query Execution

        List<Team> teamsAsList = await teamsAsQueryable.ToListAsync();
        foreach (var t in teamAsList)
        {


            Console.WriteLine(t.Name);


        }




    }
    

}
