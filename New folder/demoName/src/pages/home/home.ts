import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  public user: FormGroup
  constructor(public navCtrl: NavController, private fb: FormBuilder) {
    this.user = fb.group({
      'firstName': [null,Validators.required],
      'lastName': [null,Validators.required],
      'sex': [null,Validators.required],
      'otherSex': [null,Validators.required]
    })
  }

  onSubmit() {
    console.log(this.user.value);
    console.log(this.user.get('firstName').invalid);

    this.navCtrl.push("DemoPage", { SendData: this.user.value })
  }
}
