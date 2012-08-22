require 'watir-webdriver'
 
Before do
  @b = Watir::Browser.new :chrome
end
 
After do
  @b.close
end