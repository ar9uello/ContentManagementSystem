import { Component } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { ContentService } from '@proxy/contents/content.service';

@Component({
  selector: 'app-content',
  standalone: true,
  imports: [],
  templateUrl: './content.component.html',
  styleUrl: './content.component.scss'
})
export class ContentComponent {
  content: SafeHtml | undefined;

  constructor(
    private route: ActivatedRoute,
    private contentService: ContentService,
    private sanitizer: DomSanitizer
  ) {

  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id) {
        this.contentService.getContent(id).subscribe(data => {
          const htmlContent = atob(data.htmlContent);
          this.content = this.sanitizer.bypassSecurityTrustHtml(htmlContent);
        });
      }
    });
  }
}
