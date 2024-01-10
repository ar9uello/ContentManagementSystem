import { RoutesService, eLayoutType } from '@abp/ng.core';
import { Component } from '@angular/core';
import { ContentService } from '@proxy/contents/content.service';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
  `,
})
export class AppComponent {

  constructor(
    private contentService: ContentService,
    private routesService: RoutesService
  ) { }

  ngOnInit() {
    this.contentService.GetAll().subscribe(data => {
      data.items.forEach((route) => {
        this.routesService.add([
          {
            path: `/content/${route.id}`,
            name: `::${route.name}`,
            iconClass: 'fas fa-link',
            layout: eLayoutType.application,
          },
        ]);
      });
    });
  }

}
