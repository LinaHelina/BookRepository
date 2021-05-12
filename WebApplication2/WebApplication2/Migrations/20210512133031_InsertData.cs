using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice","ProductImageUrl", "ProductAuthor" },
                values: new object[] { 1, "Pride and Prejudice", 10.42 ,"https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439518.jpg", "Jane Austen" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] {2, "The Picture of Dorian Gray", 9.22, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439570.jpg", "Oscar Wilde" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 3, "Dracula", 11.88, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439846.jpg", "Bram Stocker" });
            
            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 1, "04.02.2003", "448", "Penguin Putnam Inc", "Classic Books", "English", "0141439513", "Few have failed to be charmed by the witty and independent spirit of Elizabeth Bennet in Austen's beloved classic Pride and Prejudice. When Elizabeth Bennet first meets eligible bachelor Fitzwilliam Darcy, she thinks him arrogant and conceited; he is indifferent to her good looks and lively mind. When she later discovers that Darcy has involved himself in the troubled relationship between his friend Bingley and her beloved sister Jane, she is determined to dislike him more than ever. In the sparkling comedy of manners that follows, Jane Austen shows us the folly of judging by first impressions and superbly evokes the friendships, gossip and snobberies of provincial middle-class life.", 1, "Pride and Prejudice", "https://historyandfilmblog.files.wordpress.com/2017/11/pride_prejudice_2005_1024x768_5275651.jpg?w=1024" });
            
            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 2, "04.02.2003", "304", "Penguin Putnam Inc", "Classic Books", "English", "0141439572", "Oscar Wilde's alluring novel of decadence and sin was a succes de scandale on publication. It follows Dorian Gray who, enthralled by his own exquisite portrait, exchanges his soul for eternal youth and beauty. Influenced by his friend Lord Henry Wotton, he is drawn into a corrupt double life, indulging his desires in secret while remaining a gentleman in the eyes of polite society. Only his portrait bears the traces of his depravity. This definitive edition includes a selection of contemporary reviews condemning the novel's immorality.", 2, "The Picture of Dorian Gray", "https://www.denofgeek.com/wp-content/uploads/2018/10/dorian-gray-tv-show-the-cw.jpg?resize=768%2C432" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 3, "01.05.2003", "512", "Penguin Putnam Inc", "Classic Books", "English", "014143984X", "When Jonathan Harker visits Transylvania to help Count Dracula purchase a London house, he makes horrifying discoveries in his client's castle. Soon afterwards, disturbing incidents unfold in England: a ship runs aground on the shores of Whitby, its crew vanished; beautiful Lucy Westenra slowly succumbs to a mysterious, wasting illness, her blood drained away; and the lunatic Renfield raves about the imminent arrival of his 'master'. In the ensuing battle of wills between the sinister Count and a determined group of adversaries - led by the intrepid vampire hunter Abraham van Helsing - Bram Stoker created a masterpiece of the horror genre, probing into questions of identity, sanity and the dark corners of Victorian sexuality and desire.", 3, "Dracula", "https://www.denofgeek.com/wp-content/uploads/2017/06/dracula-bela-lugosi.jpg?resize=768%2C432" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
