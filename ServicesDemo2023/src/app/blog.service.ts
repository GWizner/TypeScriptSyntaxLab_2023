import { Injectable } from '@angular/core';

import { Article} from './article';
import { ARTICLES} from './mock-articles';
import { Observable, of} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

 getArticlesSynchronous(): Article[] {
  
  return ARTICLES;
 }

 getArticles(): Observable<Article[]> {

  const articles = of(ARTICLES);
  console.log(articles);

  return articles;

 }
}
