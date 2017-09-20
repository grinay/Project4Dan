namespace Project4Dan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTopicTableAndSeedIt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TextPhraseToDisplay = c.String(),
                        DataToDisplayInPieChartOrGraph = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            //Seed table with provided example data
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('zero', 'A phrase from listA index number zero', 'TheData:0,3,4,5')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('one', 'A phrase from listA index number one', 'TheData:1,3,4,5')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('two', 'A phrase from listA index number two', 'TheData:2,3,4,5')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('three', 'A phrase from listA index number three', 'TheData:3,3,4,8')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('four', 'A phrase from listA index number four', 'TheData:4,3,4,8')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('five', 'A phrase from listA index number five', 'TheData:5,3,4,5')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('six', 'A phrase from listA index number six', 'TheData:6,3,4,5')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('seven', 'A phrase from listA index number seven', 'TheData:7,3,4,2')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('eight', 'A phrase from listA index number eight', 'TheData:8,3,4,2')");
            Sql("INSERT INTO Topics(Title, TextPhraseToDisplay, DataToDisplayInPieChartOrGraph) VALUES('nine', 'A phrase from listA index number nine', 'TheData:9,3,4,2')");

        }

        public override void Down()
        {
            DropTable("dbo.Topics");
        }
    }
}
