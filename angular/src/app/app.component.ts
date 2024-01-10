import { Component } from '@angular/core';
import { MenuService } from '@proxy/menu.service';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
  `,
})
export class AppComponent {

  constructor(
    private menuService: MenuService
  ) { }

  ngOnInit() {
    this.menuService.refresh();
  }

}
