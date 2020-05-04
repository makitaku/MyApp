using Microsoft.EntityFrameworkCore;
using MyApp.Models.Entities;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Montain> Montains { get; set; }
        public DbSet<Prefecture> Prefectures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prefecture>()
                .HasData(
                    new Prefecture() { Id = 1, Name = "北海道", ShortName = "北海道", Order = 1 },
                    new Prefecture() { Id = 2, Name = "青森県", ShortName = "青森", Order = 2 },
                    new Prefecture() { Id = 3, Name = "岩手県", ShortName = "岩手", Order = 3 },
                    new Prefecture() { Id = 4, Name = "宮城県", ShortName = "宮城", Order = 4 },
                    new Prefecture() { Id = 5, Name = "秋田県", ShortName = "秋田", Order = 5 },
                    new Prefecture() { Id = 6, Name = "山形県", ShortName = "山形", Order = 6 },
                    new Prefecture() { Id = 7, Name = "福島県", ShortName = "福島", Order = 7 },
                    new Prefecture() { Id = 8, Name = "茨城県", ShortName = "茨城", Order = 8 },
                    new Prefecture() { Id = 9, Name = "栃木県", ShortName = "栃木", Order = 9 },
                    new Prefecture() { Id = 10, Name = "群馬県", ShortName = "群馬", Order = 10 },
                    new Prefecture() { Id = 11, Name = "埼玉県", ShortName = "埼玉", Order = 11 },
                    new Prefecture() { Id = 12, Name = "千葉県", ShortName = "千葉", Order = 12 },
                    new Prefecture() { Id = 13, Name = "東京都", ShortName = "東京", Order = 13 },
                    new Prefecture() { Id = 14, Name = "神奈川県", ShortName = "神奈川", Order = 14 },
                    new Prefecture() { Id = 15, Name = "新潟県", ShortName = "新潟", Order = 15 },
                    new Prefecture() { Id = 16, Name = "富山県", ShortName = "富山", Order = 16 },
                    new Prefecture() { Id = 17, Name = "石川県", ShortName = "石川", Order = 17 },
                    new Prefecture() { Id = 18, Name = "福井県", ShortName = "福井", Order = 18 },
                    new Prefecture() { Id = 19, Name = "山梨県", ShortName = "山梨", Order = 19 },
                    new Prefecture() { Id = 20, Name = "長野県", ShortName = "長野", Order = 20 },
                    new Prefecture() { Id = 21, Name = "岐阜県", ShortName = "岐阜", Order = 21 },
                    new Prefecture() { Id = 22, Name = "静岡県", ShortName = "静岡", Order = 22 },
                    new Prefecture() { Id = 23, Name = "愛知県", ShortName = "愛知", Order = 23 },
                    new Prefecture() { Id = 24, Name = "三重県", ShortName = "三重", Order = 24 },
                    new Prefecture() { Id = 25, Name = "滋賀県", ShortName = "滋賀", Order = 25 },
                    new Prefecture() { Id = 26, Name = "京都府", ShortName = "京都", Order = 26 },
                    new Prefecture() { Id = 27, Name = "大阪府", ShortName = "大阪", Order = 27 },
                    new Prefecture() { Id = 28, Name = "兵庫県", ShortName = "兵庫", Order = 28 },
                    new Prefecture() { Id = 29, Name = "奈良県", ShortName = "奈良", Order = 29 },
                    new Prefecture() { Id = 30, Name = "和歌山県", ShortName = "和歌山", Order = 30 },
                    new Prefecture() { Id = 31, Name = "鳥取県", ShortName = "鳥取", Order = 31 },
                    new Prefecture() { Id = 32, Name = "島根県", ShortName = "島根", Order = 32 },
                    new Prefecture() { Id = 33, Name = "岡山県", ShortName = "岡山", Order = 33 },
                    new Prefecture() { Id = 34, Name = "広島県", ShortName = "広島", Order = 34 },
                    new Prefecture() { Id = 35, Name = "山口県", ShortName = "山口", Order = 35 },
                    new Prefecture() { Id = 36, Name = "徳島県", ShortName = "徳島", Order = 36 },
                    new Prefecture() { Id = 37, Name = "香川県", ShortName = "香川", Order = 37 },
                    new Prefecture() { Id = 38, Name = "愛媛県", ShortName = "愛媛", Order = 38 },
                    new Prefecture() { Id = 39, Name = "高知県", ShortName = "高知", Order = 39 },
                    new Prefecture() { Id = 40, Name = "福岡県", ShortName = "福岡", Order = 40 },
                    new Prefecture() { Id = 41, Name = "佐賀県", ShortName = "佐賀", Order = 41 },
                    new Prefecture() { Id = 42, Name = "長崎県", ShortName = "長崎", Order = 42 },
                    new Prefecture() { Id = 43, Name = "熊本県", ShortName = "熊本", Order = 43 },
                    new Prefecture() { Id = 44, Name = "大分県", ShortName = "大分", Order = 44 },
                    new Prefecture() { Id = 45, Name = "宮崎県", ShortName = "宮崎", Order = 45 },
                    new Prefecture() { Id = 46, Name = "鹿児島県", ShortName = "鹿児島", Order = 46 },
                    new Prefecture() { Id = 47, Name = "沖縄県", ShortName = "沖縄", Order = 47 }
                );

        }
    }
}
