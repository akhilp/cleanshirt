require 'watir-webdriver'

#b = Watir::Browser.new :chrome
b = Watir::Browser.new# :chrome, :switches => %w[--ignore-certificate-errors]

Given /^I have opened "(.*?)"$/ do |url|  
    b.goto url
end

Then /^I input the credentials$/ do
	b.text_field(:id => 'customer').set 'dev0002'
	b.text_field(:id => 'username').set 'paras'
	b.text_field(:id => 'password').set 'password'
end

When /^I hit submit$/ do
  	b.button(:name => 'gologin').click
end

Then /^I should see a link to "(.*?)" with text "(.*?)"$/ do |arg1, arg2|
  	l = b.link :text => arg2
	l.exists?
	l.click
end

Given /^I am logged in to "(.*?)"$/ do |arg1|
	l = b.link :text => arg1
	l.exists?
end

When /^I see the word "(.*?)"$/ do |arg1|
    d = b.span :text => 'arg1'
	d.exists?
end

Then /^I should logout "(.*?)"$/ do |arg1|
	b.goto arg1
end