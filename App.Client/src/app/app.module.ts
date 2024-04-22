import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LogsComponent } from './logs/logs.component';
import { MainComponent } from './main/main.component';
import { MenuComponent } from './main/menu/menu.component';

@NgModule({
  declarations: [
    AppComponent,
    LogsComponent,
    MainComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule, HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
