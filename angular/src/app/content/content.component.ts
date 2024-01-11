import { AuthService } from '@abp/ng.core';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { ContentService } from '@proxy/contents/content.service';

@Component({
  selector: 'app-content',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './content.component.html',
  styleUrl: './content.component.scss'
})
export class ContentComponent {
  content: SafeHtml | undefined;
  id: string;
  
  constructor(
    private route: ActivatedRoute,
    private contentService: ContentService,
    private sanitizer: DomSanitizer,
    private authService: AuthService
  ) {}
  
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
      if (this.id) {
        this.contentService.getContent(this.id).subscribe(data => {
          const htmlContent = atob(data.htmlContent);
          this.content = this.sanitizer.bypassSecurityTrustHtml(htmlContent);
        });
      }
    });
  }
}
