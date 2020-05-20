import { SlowDITemplatePage } from './app.po';

describe('SlowDI App', function() {
  let page: SlowDITemplatePage;

  beforeEach(() => {
    page = new SlowDITemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
