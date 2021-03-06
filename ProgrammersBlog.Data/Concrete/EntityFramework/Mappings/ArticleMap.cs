﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a  => a.Id).ValueGeneratedOnAdd();
            builder.Property(a  => a.Title).HasMaxLength(100);
            builder.Property(a  => a.Title).IsRequired(true);
            builder.Property(a  => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(navigationExpression: a => a.Category).WithMany(navigationExpression: c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(navigationExpression: a => a.User).WithMany(navigationExpression: u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            //builder.HasData(new Article
            //{
            //    Id = 1,
            //  CategoryId =1,
          //    Title = "Çocuklar Ve Gençler İçin",
          //      Content = "Covid - 19 pandemisi nedeniyle 20 yaş altı gençlerimiz ve çocuklarımız evde kalmak mecburiyetinde. Peki bu gençler ve çocuklar evde hareket aktivitesinden, spordan, çoklu duyusal eğitimden ve sosyal ortamdan uzak kalması onların beyin gelişimini nasıl olumsuz etkiliyor. Çünkü beyin gelişimine baktığımızda beynin iki yarı küresini birbirine bağlayan organın olgunlaşma süresi ortalama olarak 25 yıl sürüyor.",
          //      Thumbnail= "Default.jpg",
          //      SeoDescription= "Çocuklar Ve Gençler İçin",
          //      SeoTags = "Covid19, Çocuk psikolojisi, Covid çocuk",
          //      SeoAuthor = "Şeyma Altunbaş",
          //      Date = DateTime.Now,
          //      IsActive = true,
          //      IsDeleted = false,
          //      CreatedByName = "InitialCreate",
          //      CreatedDate = DateTime.Now,
          //      ModifiedByName = "InitialCreate",
          //      ModifiedDate = DateTime.Now,
          //     Note = "Çocuklar Ve Gençler İçin",
         //       UserId= 1,
         //       ViewsCount = 100,
         //       CommentCount = 1



           // },
           // new Article
            //{
              //  Id = 2,
               // CategoryId = 2,
                //Title = "Yetişkinler İçin",
                //Content = "Günümüzde iş hayatında yaşanılan en büyük problem kişilerin yapılması gereken işe yeterince dikkatini verememesidir. Bu durumun birden fazla nedeni olabilir. Örneğin, aynı anda birden fazla göreve sahip olma, duygu ve düşüncelerin ev, arkadaş, özel hayat gibi başka yerlerde olması; açık ofis ortamında diğer etmenlerden dolayı dikkatin dağılması yada internet ortamında geçirilen zaman olabilir. Ya da karşınızdaki konuşurken uzun süre dinlemekte zorlanmak, konuşmadan tamamen kopmak, işleri sürekli ertelemek ve işleri bir türlü sıraya koyamamak gibi.",
                //Thumbnail = "Default.jpg",
                //SeoDescription = "Yetişkin Dikkat Eksikliği ve İş Performansı",
                //SeoTags = "Yetişkin ",
                //SeoAuthor = "Şeyma Altunbaş",
                //Date = DateTime.Now,
                //IsActive = true,
               // IsDeleted = false,
                //CreatedByName = "InitialCreate",
                //CreatedDate = DateTime.Now,
               // ModifiedByName = "InitialCreate",
                //ModifiedDate = DateTime.Now,
                //Note = "Çocuklar Ve Gençler İçin",
//                ViewsCount = 200,
                //CommentCount = 3
            //}
            //);

        }
    }
}
