import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

// responsible for providing the code to bootstrap our AppModule -> AppComponent -> index.html
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
