import { Component, OnInit, AfterViewInit } from '@angular/core';
import { Article } from '../article';
import { BlogService } from '../blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit, AfterViewInit{

    constructor(private blogService: BlogService){

    }



  articles: Article[] = [];
  results: Article[] = [];

  ngOnInit(): void {
    console.log("Blog component OnInit!")
    this.getArticles();

    this.results = this.articles;
  }

  ngAfterViewInit(): void {
    console.log("after view init.")
  }


  getArticles(): void {
      this.blogService.getArticles()
            .subscribe(
              (result: Article[]) => {
              this.articles = result;
              console.log(result);
              }
            );

  }

  testClick(): void {
    console.log("clicked button!")
  }


  filterArticles(searchString: string): void {
    this.results = this.articles.filter(article => 
      article.excerpt.toLowerCase().includes(searchString.toLowerCase()) ||
      article.title.toLowerCase().includes(searchString.toLowerCase())
    );
  }
}
