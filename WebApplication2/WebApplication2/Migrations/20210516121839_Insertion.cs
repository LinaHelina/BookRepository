using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Insertion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "Products",
              columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
              values: new object[] { 1, "Pride and Prejudice", 10.42, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439518.jpg", "Jane Austen" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 2, "The Picture of Dorian Gray", 9.22, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439570.jpg", "Oscar Wilde" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 3, "Dracula", 11.88, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141439846.jpg", "Bram Stocker" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 4, "1984", 12.83, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1411/9780141187761.jpg", "George Orwell" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 5, "Jane Eyre", 13.03, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1414/9780141441146.jpg", "Charlotte Bronte" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 6, "The Count of Monte Cristo", 22.67, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1404/9780140449266.jpg", "Alexandre Dumas" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 7, "Dune", 15.15, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/3409/9780340960196.jpg", "Frank Herbert" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 8, "Anna Karenina", 18.69, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1404/9780140449174.jpg", "Leo Tolstoy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 9, "Fahrenheit 451", 13.69, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/0065/9780006546061.jpg", "Ray Bradbury" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 10, "A Clockwork Orange", 12.00, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/2419/9780241951446.jpg", "Anthony Burgess" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 11, "Crime and Punishment", 15.40, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1404/9780140449136.jpg", "Fyodor Dostoyevsky" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductImageUrl", "ProductAuthor" },
                values: new object[] { 12, "The Three Musketeers", 19.15, "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/mid/9780/1414/9780141442341.jpg", "Alexandre Dumas" });




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

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 4, "01.02.2008", "384", "Penguin Putnam Inc", "Classic Books", "English", "014118776X", "Nineteen Eighty Four, by George Orwell - Akasha Classics, AkashaPublishing.Com - It was a bright cold day in April, and the clocks were striking thirteen. Winston Smith, his chin nuzzled into his breast in an effort to escape the vile wind, slipped quickly through the glass doors of Victory Mansions, though not quickly enough to prevent a swirl of gritty dust from entering along with him. The hallway smelt of boiled cabbage and old rag mats. At one end of it a coloured poster, too large for indoor display, had been tacked to the wall. It depicted imply an enormous face, more than a metre wide: the face of a man of about forty-five, with a heavy black moustache and ruggedly handsome features. Winston made for the stairs. It was no use trying the lift.", 4, "1984", "https://purplehaze.rocks/wp-content/uploads/2020/09/Retsenziya-na-knigu-Dzhordzha-Orue%60lla----1984---e1600612296882-961x580.jpg" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 5, "01.02.2008", "624", "Penguin Putnam Inc", "Classic Books", "English", "0141441143", "Charlotte Brontë's moving masterpiece - the novel that has been teaching true strength of character for generations (The Guardian). Nominated as one of America's best-loved novels by PBS's The Great American Read A novel of intense power and intrigue, Jane Eyre has dazzled generations of readers with its depiction of a woman's quest for freedom. Having grown up an orphan in the home of her cruel aunt and at a harsh charity school, Jane Eyre becomes an independent and spirited survivor-qualities that serve her well as governess at Thornfield Hall. ", 5, "Jane Eyre", "https://ichef.bbci.co.uk/news/976/cpsprodpb/160BB/production/_105399209_janeyeyretv.jpg" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 6, "01.06.2003", "1312", "Penguin Putnam Inc", "Classic Books", "English", "0141442243", "Thrown in prison for a crime he has not committed, Edmond Dantes is confined to the grim fortress of If. There he learns of a great hoard of treasure hidden on the Isle of Monte Cristo and he becomes determined not only to escape, but also to use the treasure to plot the destruction of the three men responsible for his incarceration. Dumas' epic tale of suffering and retribution, inspired by a real-life case of wrongful imprisonment, was a huge popular success when it was first serialized in the 1840s.", 6, "The Count of Monte Cristo", "https://play-lh.googleusercontent.com/proxy/VX37tZS3LnYFq5XTNYatBXmHFTq1Dw1U7XIlG-NKXWa3RHA33psj36XYNmoXuxchG6p4arvsJdZvlEnYpEaG-X1Qi7uyMtEpDf6v5R3vu249wZx-aA=w720-h405-rw" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 7, "23.07.2015", "592", "Penguin Putnam Inc", "Classic Books", "English", "0211442243", "Before The Matrix, before Star Wars, before Ender's Game and Neuromancer, there was Dune: winner of the prestigious Hugo and Nebula awards, and widely considered one of the greatest science fiction novels ever written.Melange, or 'spice', is the most valuable - and rarest - element in the universe; a drug that does everything from increasing a person's life-span to making intersteller travel possible. And it can only be found on a single planet: the inhospitable desert world Arrakis.", 7, "Dune", "https://u.kanobu.ru/editor/images/70/7553609f-ea4e-49e1-a09f-ddff16317266.jpg" });


            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 8, "01.06.2003", "864", "Penguin Putnam Inc", "Classic Books", "English", "0140449175", "The heroine of Tolstoy's epic of love and self-destruction, Anna Karenina has beauty, wealth, popularity and an adored son, but feels that her life is empty until she encounters the impetuous officer Count Vronsky. Their subsequent affair scandalizes society and family alike, and brings jealousy and bitterness in its wake. Contrasting with this is the vividly observed story of Levin, a man striving to find contentment and a meaning to his life - and also a self-portrait of Tolstoy himself. This award-winning translation has been acclaimed as the definitive English version of Tolstoy's masterpiece.", 8, "Anna Karenina", "https://www.film.ru/sites/default/files/images/DSC_0513.JPG" });


            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 9, "08.06.2012", "192", "Penguin Putnam Inc", "Classic Books", "English", " 0141442243", "The hauntingly prophetic classic novel set in a not-too-distant future where books are burned by a special task force of firemen.", 9, "Ray Bradbury", "https://www.syfy.com/sites/syfy/files/wire/legacy/fahrenheit_451_hero.jpg" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 10, "08.02.2019", "144", "Penguin Putnam Inc", "Classic Books", "English", " 0141442243", "A Clockwork Orange is the daring and electrifying book by Anthony Burgess that inspired one of the most notorious films ever made, beautifully repackaged as part of the Penguin Essentials range.", 10, "Anthony Burgess", "https://homemcr.org/app/uploads/2012/06/A-Clockwork-Orange-e1340381775451-940x460.jpg" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 11, "08.12.2002", "192", "Penguin Putnam Inc", "Classic Books", "English", " 0141442243", "Dostoyevsky's great novel of damnation and redemption evokes a world where the lines between innocence and corruption, good and evil, blur. It tells the story of Raskolnikov, a destitute and desperate former student, who wanders through the slums of St Petersburg and commits a random murder without remorse or regret. He imagines himself to be beyond conventional moral laws. But as he embarks on a dangerous game of cat and mouse with a police investigator, Raskolnikov is pursued by the growing voice of his conscience and finds the noose of his own guilt tightening around his neck. ", 11, "Fyodor Dostoyevsky", "https://scrapsfromtheloft.com/wp-content/uploads/2018/04/Crime-and-Punishement-Illustration-by-Stanley-Wyatt.jpg" });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "PublicationDate", "PageAmount", "Publisher", "Category", "ProductLanguage", "IsbnNumber", "ShortDescription", "ProductId", "ProductName", "ProductImage" },
                values: new object[] { 12, "08.06.2012", "192", "Penguin Putnam Inc", "Classic Books", "English", " 0141442243", "Young D'Artagnan arrives in Paris to join the King's elite guards, but almost immediately finds he is duelling with some of the very men he has come to swear allegiance to - Porthos, Athos and Aramis, inseparable friends: the Three Musketeers. Soon part of their close band, D'Artagnan's loyalty to his new allies puts him in the deadly path of Cardinal Richlieu's machinations. And when the young hero falls in love with the beautiful but inaccessible Constance, he finds himself in a world of murder, conspiracy and lies, with only the Musketeers to depend on. A stirring nineteenth-century tale of friendship and adventure, The Three Musketeers continues to be one of the most influential and popular pieces of French literature.", 12, "Alexandre Dumas", "https://www.slashfilm.com/wp/wp-content/images/threemusketeers-disney-cast-swords.jpg" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
