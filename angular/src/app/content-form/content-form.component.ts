import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ContentService } from '@proxy/contents/content.service';
import { MenuService } from '@proxy/menu.service';
import { NgxWigModule } from 'ngx-wig';

@Component({
  selector: 'app-content-form',
  standalone: true,
  imports: [ReactiveFormsModule, NgxWigModule],
  templateUrl: './content-form.component.html',
  styleUrl: './content-form.component.scss'
})
export class ContentFormComponent {
  id: string;
  form: FormGroup;
  originalName: string;
  isSaving: boolean = false;

  constructor(
    private fb: FormBuilder,
    private contentService: ContentService,
    private router: Router,
    private menuService: MenuService,
    private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
      this.form = this.fb.group({
        name: ['', Validators.required],
        htmlContent: ['', Validators.required],
      });

      if (this.id) {
        this.contentService.getContent(this.id)
          .subscribe(data => {
            this.originalName = data.name;
            this.form.patchValue({
              name: this.originalName,
              htmlContent: atob(data.htmlContent),
            });
          });
      }
    });
  }

  save() {
    this.isSaving = true;

    const formData = this.form.value;
    formData.guid = this.id;
    formData.htmlContent = btoa(this.form.value.htmlContent);

    this.contentService.InsertOrUpdateCMSContent(formData)
      .subscribe(data => {
        this.menuService.refresh(this.originalName);
        this.router.navigate([`/content/${data.id}`]);
      });

  }
}
