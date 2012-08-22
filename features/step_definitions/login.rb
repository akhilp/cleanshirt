require "rubygems" 
require "bundler/setup" 

require "watir-webdriver" 
require 'selenium/server' 

server = Selenium::Server.new("selenium-server-standalone-2.0b1.jar", :background => true) 
server.start 

include Selenium
capabilities = WebDriver::Remote::Capabilities.htmlunit(:javascript_enabled => true)
b = Watir::Browser.new(:remote, :url => 'http://127.0.0.1:4444/wd/hub', :desired_capabilities => capabilities) 

Given /^I have opened "(.*?)"$/ do |url|  
	b.goto url
end

b.close 
server.stop 