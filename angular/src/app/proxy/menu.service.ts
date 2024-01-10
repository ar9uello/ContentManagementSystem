import { Injectable } from "@angular/core";
import { ContentService } from "./contents/content.service";
import { AuthService, RoutesService, eLayoutType } from "@abp/ng.core";

@Injectable({
    providedIn: 'root',
})
export class MenuService {

    constructor(
        private contentService: ContentService,
        private routesService: RoutesService,
        private authService: AuthService,
    ) { }

    refresh() {
        this.contentService.GetAll().subscribe(data => {

            data.items.forEach((route) => {
                this.routesService.add([
                    {
                        path: `/content/${route.id}`,
                        name: `::${route.name}`,
                        iconClass: 'fas fa-link',
                        order: 2,
                        layout: eLayoutType.application,
                    },
                ]);
            });

            this.routesService.add([
                {
                    path: `/content-form`,
                    name: `::Create New Content`,
                    iconClass: 'fas fa-plus',
                    order: 3,
                    layout: eLayoutType.application,
                    invisible: !this.authService.isAuthenticated
                },
            ]);

        });
    }
}