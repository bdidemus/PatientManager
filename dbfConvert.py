#!/usr/bin/env python
# Author: Brett Didemus
# Date: Apr 22 2012
# Description: Convert DBF database format from the better system to sql.
# Required: dbfpy library

from datetime import datetime
from dbfpy import dbf

db = dbf.Dbf("PATIENTS.DBF")
patID = 1
for rec in db:
	sex = '0' if rec[7] == 'M' else '1'
	docID = 1 # default 1 is clinic 
	if rec[47] == 1: # Nick
		docID = 3
	elif rec[47] == 2: # gary
		docID = 2
	elif rec[47] == 3: #dr boyle
		docID = 1
	elif rec[47] == 4: # julia
		docID = 4
	
	#birthday = datetime.fromordinal(rec[5])
	print 'INSERT INTO patient (patID, patFirstName, patLastName, patSex, patHealthCard, patAddress, patPhoneNumber, patPCode, patBirthday, patReferedBy, patCity, iso, patProv, docID) VALUES(' + str(patID) + ', "' + rec[3] + '", "' + rec[2] + '", ' + sex + ', ' + \
	str(rec[21]) + ', "' + rec[8] + '", "' + str(rec[12]) + '", "' + \
	rec[11] + '", null, "' + rec[35] + '", "' + rec[9] + '", "CA", "ON", ' + str(docID) + ');'
	if rec[25] > 0:
		print 'INSERT INTO invoice (patID, invCommitted, docID) VALUES (' + str(patID) + ', 1, ' + str(docID) + ');'
		print 'INSERT INTO inv_line VALUES (LAST_INSERT_ID(), 2, 1, ' + str(rec[25]) + ');'
	elif rec[25] < 0:
		print 'INSERT INTO payment (payAmount, ptID, patID, docID) VALUES (' + str(-rec[25]) + ', 1, ' + str(patID) + ', ' + str(docID) + ');' 
	patID += 1
