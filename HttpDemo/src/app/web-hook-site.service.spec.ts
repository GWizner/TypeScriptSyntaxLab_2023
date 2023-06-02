import { TestBed } from '@angular/core/testing';

import { WebHookSiteService } from './web-hook-site.service';

describe('WebHookSiteService', () => {
  let service: WebHookSiteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WebHookSiteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
