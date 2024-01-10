import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      // {
      //   path: `/content/7f28ff2d-b942-3ef7-7113-3a10037bf204`,
      //   name: `Test 20240110 0051`,
      //   iconClass: 'fas fa-home',
      //   layout: eLayoutType.application,
      // },
    ]);
  };
}
