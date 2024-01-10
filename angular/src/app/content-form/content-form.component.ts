import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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
  form: FormGroup;
  isSaving: boolean = false;

  constructor(
    private fb: FormBuilder,
    private contentService: ContentService,
    private router: Router,
    private menuService: MenuService
  ) { }

  ngOnInit() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      htmlContent: ['', Validators.required],
    });
  }

  save() {
    this.isSaving = true;

    const formData = this.form.value;
    formData.guid = '';
    formData.htmlContent = btoa(this.form.value.htmlContent);

    this.contentService.InsertOrUpdateCMSContent(formData)
      .subscribe(data => {
        this.menuService.refresh();
        this.router.navigate([`/content/${data.id}`]);
      });

  }
}
