/*
CASES/CUSTOMERS/DEBTS
RUN SCRIPT IN PRD_DOCUMENTATION DATABASE!!
*/
SELECT 
  	   [DMTF_TABLE_NAME]
      ,[TAB_PREFIX]
      ,[DMTF_FIELD_NAME]
      ,[ALIAS_FIELD_CAPTION]
      ,[ALIAS_FIELD_DESCRIPTION]
      ,[ALIAS_FIELD_DATA_TYPE]
      ,[ALIAS_FIELD_TYPE]
      ,[ALIAS_LOOKUP_LIST]
FROM [PRD_Documentation].[dbo].[VW_DOC_TABLE_FIELDS]
WHERE DMTF_TABLE_NAME IN (
 'AT_ACCOUNTING_BOOKS'
,'AT_ACCOUNTING_BOOKS_JOURNAL_ENTRY_SETS'
,'AT_ACCOUNTING_EVENTS'
,'AT_ACCOUNTING_EXPORT_LOG'
,'AT_ACCOUNTING_EXPORT_NAV_GENERAL_LEDGER'
,'AT_ACCOUNTING_EXPORT_NAV_GENERAL_LEDGER_HISTORY'
,'AT_ACCOUNTING_EXPORT_NAV_SALES'
,'AT_ACCOUNTING_EXPORT_NAV_SALES_HISTORY'
,'AT_ACCOUNTING_EXPORT_NAV_SALES_STAGING'
,'AT_ACCOUNTING_EXPORT_NAV_VENDOR'
,'AT_ACCOUNTING_EXPORT_NAV_VENDOR_HISTORY'
,'AT_ACCOUNTING_GENERAL_LEDGER_ACCOUNTS'
,'AT_ACCOUNTING_JOURNAL_ENTRIES'
,'AT_ACCOUNTING_JOURNAL_ENTRY_SET_DETAIL'
,'AT_ACCOUNTING_JOURNAL_ENTRY_SET_DETAIL_HISTORY'
,'AT_ACCOUNTING_JOURNAL_ENTRY_SET_HEADER'
,'AT_ACCOUNTING_JOURNAL_ENTRY_SET_HEADER_HISTORY'
,'AT_ACCOUNTING_JOURNAL_ENTRY_SETS'
,'AT_ACTIV'
,'AT_ACTIV_CAT'
,'AT_ACTIV_CAT_DEP'
,'AT_ACTIV_CAT_MEMBERS'
,'AT_ACTIV_CAT_TEAMS'
,'AT_ACTIV_CLOSING_TASKS'
,'AT_ACTIV_CUSTOMER_COUNTERS'
,'AT_ACTIV_DEP_TEAM_ORDER'
,'AT_ACTIV_RELATIONS'
,'AT_ACTIV_STREAMS'
,'AT_CASE_STREAM_EXCLUSIONS'
,'AT_CASE_STREAM_EXCLUSIONS_HIST'
,'AT_ASSIGNMENT_EXCEPTIONS'
,'AT_ASSIGNMENT_STREAM_EXCEPTIONS'
,'AT_ASSIGN_MODEL'
,'AT_ASSIGN_MODEL_CRIT'
,'AT_COLLECTION_COMP_PARAMS'
,'AT_CUST_CASE_EXCL_LOG'
,'AT_EXTERNAL_COMPANIES'
,'AT_EXTERNAL_COMPANIES_ALIASES'
,'AT_EXTERNAL_COMPANIES_PERFORMANCE_DETAILS'
,'AT_EXTERNAL_COMPANIES_PERFORMANCE_EXCEPTIONS'
,'AT_EXTERNAL_COMPANIES_PERFORMANCE_FILES'
,'AT_EXTERNAL_COMPANIES_PERFORMANCE_HEADER'
,'AT_EXTERNAL_COMPANIES_PROCESS_TYPES'
,'AT_EXTERNAL_COMPANIES_REGIONS'
,'AT_EXTERNAL_COMPANY_AUTHORITIES'
,'AT_EXTERNAL_COMPANY_LAWYERS'
,'AT_EXTERNAL_COMPANY_STREAM_PACKET_TYPES'
,'AT_EXTERNAL_COMPANY_STREAMS'
,'AT_PACK_ASSIGN_SNAP'
,'AT_PACKET_ASSIGNMENT_ALGORITHMS'
,'AT_PACKET_ASSIGNMENT_DISTRIBUTION_METHODS'
,'AT_PACKET_COMPANIES'
,'AT_PACKET_COMPANY_CASES'
,'AT_PACKET_STRATEGY_STEPS'
,'AT_PACKET_WORK_LISTS'
,'AT_PACKETS'
,'AT_PARAMS_OF_COLLECTION_COMP'
,'AT_REGIONS'
,'AT_REGIONS_POSTAL_SECTORS'
,'AT_RETURNS'
,'AT_RETURNS_REASONS'
,'AT_REV_CASES'
,'AT_REV_CRITERIA'
,'AT_REV_CRITERIA_VALUES'
,'AT_REV_TYPE_STREAMS'
,'AT_REV_TYPES'
,'AT_REVOC_PACKET_COMPANIES'
,'AT_REVOCATIONS'
,'AT_ARRANGEMENT_CAMPAIGNS'
,'AT_DISCOUNT_POLICIES'
,'AT_POLICY_TYPES'
,'AT_SECTORS'
,'AT_SETTLEMENT_POLICIES'
,'AT_SETTLEMENT_POLICY_TRANSITION_CRITERIA'
,'AT_SETTLEMENT_POLICY_TRANSITION_CRITERIA_VALUES'
,'AT_SETTLEMENT_POLICY_TRANSITIONS'
,'AT_SETTLEMENTS_EXT'
,'AT_SETTLEMENTS_EXT_CASES'
,'AT_SETTLEMENTS_EXT_CASES_EXTENSION'
,'AT_SETTLEMENTS_EXT_CASES_TRANSACTIONS'
,'AT_SETTLEMENTS_EXT_CONTACTS'
,'AT_SETTLEMENTS_EXT_DEBT_ITEMS'
,'AT_SETTLEMENTS_EXT_HISTORY'
,'AT_SETTLEMENTS_EXT_INTEREST_TYPES'
,'AT_SETTLEMENTS_EXT_PAYMENTS_REISSUE_DD_SCHEDULE'
,'AT_SETTLEMENTS_EXT_PAYMENTS_SCHEDULE'
,'AT_SETTLEMENTS_EXT_PHASED_PLAN'
,'AT_SETTLEMENTS_EXT_TYPE_APPROVAL_LEVEL_OVERRIDES'
,'AT_SETTLEMENTS_EXT_TYPE_APPROVAL_LEVELS'
,'AT_SETTLEMENTS_EXT_TYPE_OVERRIDES'
,'AT_SETTLEMENTS_EXT_TYPES'
,'AT_ATTACHMENTS'
,'AT_ATT_REGISTER'
,'DBEvents'
,'LoginsOK'
,'AT_EXTERNAL_INTRADAY_UPLOAD_CHARGES'
,'AT_EXTERNAL_SYSTEM_ACTIONS_IMPORTED'
,'AT_EXTERNAL_SYSTEM_ACTIONS_LOADED'
,'AT_EXTERNAL_SYSTEM_ACTIONS_REJECTED'
,'AT_EXTERNAL_SYSTEM_PAYMENTS_IMPORTED'
,'AT_EXTERNAL_SYSTEM_PAYMENTS_LOADED'
,'AT_EXTERNAL_SYSTEM_PAYMENTS_REJECTED'
,'AT_BATCH_PROCESS_EXECUTION'
,'AT_BATCH_PROCESS_REQUEST_DETAILS'
,'AT_BATCH_PROCESS_REQUESTS'
,'AT_BILLING_AGGREGATIONS'
,'AT_BILLING_DETAIL_DOCUMENTS'
,'AT_BILLING_DETAILS'
,'AT_BILLING_DETAILS_EXTENSION'
,'AT_BILLING_DETAILS_OVERPAYMENTS'
,'AT_BILLING_DETAILS_REMITT_BY_CASE'
,'AT_BILLING_DETAILS_REMITT_BY_DEBT_ITEM'
,'AT_BILLING_HEADER'
,'AT_BILLING_HEADER_DOCUMENTS'
,'AT_BILLING_PAYMENT_FILE'
,'AT_BILLING_PAYMENT_FILE_DETAIL'
,'AT_BILLING_PERIOD_DETAILS'
,'AT_BILLING_PERIODS'
,'AT_BILLING_PORTFOLIO_DEBTOR_CHARGES'
,'AT_COMMISSION_CALCULATIONS_OPTIONS'
,'AT_COMMISSION_POLICIES'
,'AT_COMMISSION_POLICIES_CONFIGURATION'
,'AT_COMMISSION_POLICY_DEBT_ELEMENTS'
,'AT_COMMISSION_POLICY_RANGES'
,'AT_COMMISSION_POLICY_RANGES_DEBT_ELEMENTS'
,'AT_COMMISSION_POLICY_STATUSES_DEBT_ELEMENTS'
,'AT_COMMISSION_POLICY_STATUSES_RANGES'
,'AT_COMMISSION_PRICING_MODELS'
,'AT_COMMISSION_SCALING_OPTIONS'
,'AT_COMMISSION_STATISTICS'
,'AT_DEBT_ITEMS_COMMISSION_POLICIES'
,'AT_PORTFOLIO_BILLING_CONFIGURATION'
,'AT_CASE_ACTIV'
,'AT_CASE_ACTIV_ACCOUNTING_EXPENSES'
,'AT_CASE_ACTIV_ADDRESS'
,'AT_CASE_ACTIV_ATTACHMENTS'
,'AT_CASE_ACTIV_DELETED'
,'AT_CASE_ACTIV_EXTENDED'
,'AT_CASE_ACTIV_HIST'
,'AT_CASE_ACTIV_TO_BE_DELETED'
,'AT_CLOSED_CASES_ACTIVITIES'
,'AT_CUST_PROM'
,'AT_CUST_PROM_DELETED'
,'AT_CUST_PROM_HIST'
,'AT_TASKS'
,'AT_TASKS_DELETED'
,'AT_BUCKET_ANALYSIS'
,'AT_CASE_COLLECTION_HISTORY'
,'AT_CASE_EOM_BALANCES'
,'AT_CASE_EOM_INTERESTS'
,'AT_CASE_IMPORT_MEMOS'
,'AT_CASE_INSTALLMENTS'
,'AT_CASE_INTEREST_TYPE_OVERRIDES'
,'AT_CASE_INTEREST_TYPES'
,'AT_CASE_INTEREST_TYPES_SUSPENDED'
,'AT_CASE_MEMOS'
,'AT_PMS_TRANSACTIONS'
,'AT_CASE_AGGREGATIONS'
,'AT_CASE_BILLING'
,'AT_CASE_CORE'
,'AT_CASE_EXTRA'
,'AT_CASE_EXTRA_CUSTOMERS'
,'AT_CASE_PROPERTIES'
,'AT_CASE_SCORING'
,'AT_CASE_STATISTICS'
,'AT_CASES'
,'AT_CASES_EXTENSION'
,'AT_CUSTOMER_ADDRESSES'
,'AT_CUSTOMER_CONTACTS'
,'AT_CUSTOMER_CORE'
,'AT_CUSTOMER_EXTRA'
,'AT_CUSTOMER_INTERNET_IDS'
,'AT_CUSTOMER_MEMOS'
,'AT_CUSTOMER_PHONES'
,'AT_CUSTOMER_PHONES_DELETED'
,'AT_CUSTOMER_SCORING'
,'AT_CUSTOMER_STATISTICS'
,'AT_CUSTOMER_STATISTICS_BU'
,'AT_CUSTOMERS'
,'AT_CUSTOMERS_EXTENSION'
,'AT_DEBT_ELEMENTS'
,'AT_DEBT_ELEMENTS_GROUPING'
,'AT_DEBT_ELEMENTS_GROUPING_MEMBERS'
,'AT_DEBT_ITEM_MEMOS'
,'AT_DEBT_ITEMS'
,'AT_DEBT_ITEMS_EXTENSION'
,'AT_DEBTS'
,'AT_DEBTS_EXTENSION'
,'AT_DEBTS_STATISTICS'
,'AT_MOVED_CASES_APPLICATION'
,'AT_MOVED_CASES_EXTRA'
,'AT_MOVED_CASES_HOST'
,'AT_MOVED_CASES_RESTORE_HISTORY'
,'AT_MOVED_CASES_STATISTIC'
,'AT_INTEREST_TYPE_COEFFICIENT_PERIODS'
,'AT_INTEREST_TYPE_COEFFICIENTS'
,'AT_INTEREST_TYPE_FIELD_MAPPING'
,'AT_INTEREST_TYPE_RATES'
,'AT_INTEREST_TYPES'
,'AT_CASE_CHARGED_FEES'
,'AT_CASE_CHARGED_FEES_DEMAND'
,'AT_CHARGE_NAME_OVERRIDES'
,'AT_CHARGE_NAME_OVERRIDES_LOCALIZATION'
,'AT_CHARGE_PRICELIST_VALIDITY_PERIODS'
,'AT_FEE_CHARGE_LIMIT_PERIOD_RANGES'
,'AT_FEE_CHARGE_LIMITS'
,'AT_FEE_CHARGE_PERIOD_RANGES'
,'AT_FEE_CHARGE_PERIODS'
,'AT_FEE_TYPE_CUSTOM_DEBT_ELEM'
,'AT_FEE_TYPE_FIELD_METHODS'
,'AT_FEE_TYPE_FIELDS'
,'AT_FEE_TYPE_LOCALIZATION'
,'AT_FEE_TYPES'
,'AT_FEE_TYPES_CLOSURES'
,'AT_FEE_TYPES_CREATION_METHODS'
,'AT_FEE_TYPES_NEGATIVE_CLOSURE_REASONS'
,'AT_TAX'
,'AT_TAX_RATES'
,'AT_VAT'
,'AT_VAT_RATES'
,'AT_CLAIM_CACHE_TIMESTAMPS'
,'AT_CLAIM_REASONS_PARAMETER'
,'AT_REDUCTION_RULES'
,'AT_TRANSACTION_TYPES'
,'AT_TRANSACTIONS'
,'AT_ASSIGN_PACKET_CASES'
,'AT_ASSIGN_PACKET_GROUP'
,'AT_ASSIGN_PACKETS'
,'AT_CASE_VENDOR_CUSTOM_PROPERTIES'
,'AT_VENDOR_ADDRESSES'
,'AT_VENDOR_BILLING_CONFIGURATION'
,'AT_VENDOR_COMMISSION_PARAMETERS_INTERIM'
,'AT_VENDOR_CONTACTS'
,'AT_VENDOR_CUSTOM_PROPERTIES'
,'AT_VENDOR_DEBT_ELEMENTS'
,'AT_VENDOR_FEE_TYPES'
,'AT_VENDOR_FEE_TYPES_LOCALIZATION'
,'AT_VENDOR_FEES'
,'AT_VENDOR_MEMOS'
,'AT_VENDOR_PAYMENT_TYPES'
,'AT_VENDOR_PORTFOLIO_CONTACTS'
,'AT_VENDOR_PROCESS_STATUSES'
,'AT_VENDOR_PROCESSES'
,'AT_VENDORS'
,'AT_CASE_REOPEN_REQUESTS'
,'AT_CLOSURE_CASES'
,'AT_CLOSURE_REASONS'
,'AT_CLOSURE_REASONS_MAPPING'
,'AT_CLOSURE_TYPE_EOD_FLOWS'
,'AT_CLOSURE_TYPES'
,'AT_CLOSURES'
,'AT_RLE_PROFILE_DETAILS'
,'AT_RLE_PROFILES'
,'AT_COLA_TYPES'
,'AT_COLLATERAL_CASES'
,'AT_COLLATERAL_PROVIDER_OWNERSHIP_RIGHTS'
,'AT_COLLATERAL_PROVIDERS'
,'AT_COLLATERALS'
,'AT_COLLATERALS_GENERIC'
,'AT_COLLATERALS_SNAPSHOT'
,'AT_COLLATERALS_SPECIFIC'
,'AT_REAL_PROPERTIES'
,'AT_REAL_PROPERTIES_FEATURE_COLLECTION'
,'AT_REAL_PROPERTIES_FEATURE_DEFINITION'
,'AT_REAL_PROPERTIES_FEATURE_VALUES'
,'AT_REAL_PROPERTIES_FEATURES'
,'AT_REAL_PROPERTIES_GENERIC'
,'AT_REAL_PROPERTIES_RESTRICTIONS'
,'AT_REAL_PROPERTY_INSURANCE_POLICIES'
,'AT_REAL_PROPERTY_INSURANCE_POLICY_COVERS'
,'AT_REAL_PROPERTY_INTERESTS'
,'AT_REAL_PROPERTY_OWNERSHIP_RIGHTS'
,'AT_REAL_PROPERTY_VALUATIONS'
,'AT_REAL_PROPERTY_VALUATIONS_OWNERSHIP_RIGHTS'
,'AT_ACTIVITY_SESSIONS'
,'AT_ACTIVITY_SESSIONS_EXCLUSIONS'
,'AT_CASE_ADMIN_STATE_HIST'
,'AT_EMPLOYEE_CASES_BOOKMARKED'
,'AT_EMPLOYEE_CASES_SELECTION_LOG'
,'AT_CASE_EVENT_TYPES'
,'AT_CASE_EVENT_TYPES_ACTIV'
,'AT_CASE_EVENTS'
,'AT_CASE_EVENTS_MAPPING'
,'AT_CASE_SPECIAL_TREATMENT_HISTORY'
,'AT_CONTROL_AREA_GROUP_ITEMS'
,'AT_CONTROL_AREA_GROUPS'
,'AT_SPECIAL_TREATMENTS'
,'AT_CRITERIA'
,'AT_CRITERIA_INSTALLATIONS'
,'AT_CRITERIA_JOINS'
,'AT_CRITERIA_LOOKUPS'
,'AT_CLEAN_ACCOUNTS'
,'AT_CUSTOMER_APPLICATIONS'
,'AT_CUSTOMER_APPLICATIONS_HISTORY'
,'AT_CUSTOMER_COLLECTION_HISTORY'
,'AT_CUSTOMER_CONTACT_PREFERENCES'
,'AT_CUSTOMER_CONTACTS_AT_CASES_AT_CUSTOMERS'
,'AT_CUSTOMER_EVENT_MAPPINGS'
,'AT_CUSTOMER_EVENTS'
,'AT_REQTYPE_STATUS_ACTV'
,'AT_REQUEST_CASES'
,'AT_REQUEST_PROPERTIES'
,'AT_REQUEST_TYPE_PROPERTIES'
,'AT_REQUEST_TYPES'
,'AT_REQUEST_TYPES_AGGREGATION'
,'AT_REQUESTS'
,'AT_REQUESTS_HISTORY'
,'AT_CAMPAIGNS_SOLUTION_TYPES'
,'AT_CUSTOMER_SOLUTION_CASES'
,'AT_CUSTOMER_SOLUTION_PLAN'
,'AT_CUSTOMER_SOLUTIONS'
,'AT_DISCOUNT_RATES_POLICIES'
,'AT_DISCOUNT_RATES_POLICIES_DETAILS'
,'AT_RE_DEFAULT_PROB_CURVES'
,'AT_RE_DEFAULT_PROB_CURVES_DETAILS'
,'AT_RISK_GROUPS'
,'AT_SOLUTION_CAMPAIGN_CUSTOMER_PROPERTIES'
,'AT_SOLUTION_CAMPAIGN_HEADER'
,'AT_SOLUTION_CAMPAIGNS'
,'AT_SOLUTION_TYPES'
,'AT_CUSTOMER_IE_BALANCE_ITEMS'
,'AT_CUSTOMER_IE_CASHFLOW_ITEMS'
,'AT_CUSTOMER_IE_DEBT_ITEMS'
,'AT_CUSTOMER_IE_DETAIL_ITEMS'
,'AT_CUSTOMER_IE_EXPENDITURE_ITEMS'
,'AT_CUSTOMER_IE_FINANCIAL_SUMMARY'
,'AT_CUSTOMER_IE_FINANCIAL_SUMMARY_SNAPSHOT'
,'AT_CUSTOMER_IE_GUARANTORS'
,'AT_CUSTOMER_IE_INCOME_ITEMS'
,'AT_CUSTOMER_IE_NON_PROPERTY_ASSET_ITEMS'
,'AT_CUSTOMER_IE_PROPERTIES_ITEMS'
,'AT_CUSTOMER_IE_SELF_EMPLOYED_ITEMS'
,'AT_CUSTOMER_IE_SURVEY_ITEMS'
,'AT_CUSTOMER_INCOME_EXPENDITURE'
,'AT_CUSTOMER_INCOME_EXPENDITURE_CREDITORS'
,'AT_DELETED_TRACES'
,'AT_CUSTOMERS_CALCULATED_EXTENSION'
,'AT_CUSTOMIZED_COMPLEX_CRITERIA'
,'AT_CUSTOMIZED_DEFAULTS'
,'AT_CUSTOMIZED_FIELDS'
,'AT_CUSTOMIZED_FIELDS_OVERRRIDES'
,'AT_CUSTOMIZED_MENU'
,'AT_CUSTOMIZED_MENU_ITEMS'
,'AT_CUSTOMIZED_SCREEN_TOOLBAR_ITEMS'
,'AT_CUSTOMIZED_SCREENS'
,'AT_CUSTOMIZED_TRANSLATIONS'
,'AT_CUSTOMIZED_UI_LAYOUT_CONTAINERS'
,'AT_CUSTOMIZED_UI_LAYOUT_FIELDS'
,'AT_CUSTOMIZED_UI_LAYOUTS'
,'AT_DCA_EXPORT_CONFIG'
,'AT_CASE_D3E_MODEL'
,'AT_CASE_D3E_MODEL_SNAP'
,'AT_CUSTOMER_D3E_MODEL'
,'AT_CUSTOMER_D3E_MODEL_SNAP'
,'AT_CASE_DECISION_HISTORY'
,'AT_CUSTOMER_DECISION_HISTORY'
,'AT_DECISION_TREES'
,'AT_DECISION_TREES_CRITERIA'
,'AT_DECISION_TREES_CRITERIA_VALUES'
,'AT_DECISION_TREES_HISTORY'
,'AT_DECISION_TREES_PROPERTIES'
,'AT_DEDUPLICATION_COMBINATIONS'
,'AT_DEDUPLICATION_COMBINATIONS_MEMBERS'
,'AT_CUSTOMERS_DEDUPLICATION'
,'AT_CUSTOMERS_DEDUPLICATION_HIST'
,'AT_DEDUPLICATION_COMBINATIONS_VALUES'
,'AT_DEDUPLICATION_RULES'
,'AT_STAGE_CUSTOMER_ADDRESSES'
,'AT_STAGE_CUSTOMER_PHONES'
,'AT_STAGE_CUSTOMERS'
,'AT_STAGE_DEDUPLICATION_QC'
,'AT_STAGE_DEDUPLICATION_SOURCE'
,'AT_DIALER_SETTINGS'
,'AT_DIALER_SETTINGS_DETAILS'
,'AT_ATTACHED_TABLE_CASES'
,'AT_ATTACHED_TABLES'
,'AT_ATTACHED_TABLES_FILTERS'
,'AT_ATTACHED_TABLES_MAPPING'
,'AT_ATTACHED_TABLES_MAPPING_FILTERS'
,'AT_ATTACHED_TABLES_SCHEMA_INST'
,'AT_DIALER_COMMANDS'
,'AT_DIALER_EXCLUSION'
,'AT_DIALER_EXCLUSION_HISTORY'
,'AT_DIALER_EXCLUSION_INFO'
,'AT_DIALER_EXCLUSION_ITEMS'
,'AT_DIALER_EXCLUSION_MASSIVE'
,'AT_DIALER_GDC_STATS'
,'AT_DIALER_MEASURE_HISTORY'
,'AT_DIALER_MEASURES'
,'AT_DIALER_MEDIA_INFO'
,'AT_DIALER_MESSAGES'
,'AT_DIALER_REASON_CODES'
,'AT_DIALER_SESSION_INFO'
,'AT_DLR_COUNTER_GDCS'
,'AT_DLR_GDC'
,'AT_DLR_GDC_GROUPS'
,'AT_DLR_PHONES_GDC_GROUPS'
,'AT_DLR_UDC'
,'AT_DLR_UDC_GROUPS'
,'AT_RECORDINGS'
,'AT_RUNGROUPS'
,'AT_RUNGROUPS_INMEMORY'
,'AT_FLOW_STEPS_ERROR_TRANSLATIONS'
,'AT_LAST_UPLOADS'
,'AT_EODMA_CON_ALERTS'
,'AT_EODMA_CON_EMAILS'
,'AT_EODMA_CON_NOTIFICATION_TEMPLATES'
,'AT_EODMA_CON_PROVIDERS'
,'AT_EODMA_EVENTS'
,'AT_EODMA_STATISTICS'
,'AT_GDPR_DESENSITIZATION_LOG'
,'AT_GDPR_ENTITIES'
,'AT_GDPR_EVENTS'
,'AT_GDPR_EXPORT_REQUEST_ENTITIES'
,'AT_GDPR_EXPORT_REQUESTS'
,'AT_GDPR_FIELDS'
,'AT_GDPR_FIELDS_REPOSITORY'
,'AT_GDPR_FIELDS_REPOSITORY_ANALYTICS'
,'AT_EXTERNAL_PROCESS_INSTANCE_ACCOUNTS_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_ACCOUNTS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_ACCOUNTS_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_COLLATERALS_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_COLLATERALS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_COLLATERALS_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARALL_STAGE_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARALL_STAGE_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARALLEL_STAGE_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARTICIPATNS_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARTICIPATNS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_PARTICIPATNS_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_REAL_PROP_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_REAL_PROP_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_REAL_PROP_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_SOLUTIONS_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_SOLUTIONS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_SOLUTIONS_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEP_ACCOUN_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEP_ACCOUN_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEP_ACCOUNTS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEPS_IMPORTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEPS_LOADED'
,'AT_EXTERNAL_PROCESS_INSTANCE_STEPS_REJECTED'
,'AT_EXTERNAL_PROCESS_INSTANCE_WARNINGS'
,'AT_CONTEXT'
,'AT_CONTEXT_DETAILS'
,'AT_CONTEXT_SECTION'
,'AT_CUSTOMER_PAYMENT_SUBSCRIPTION_TYPES'
,'AT_CUSTOMER_PAYMENT_SUBSCRIPTIONS'
,'AT_CUSTOMER_PAYMENT_SUBSCRIPTIONS_SETT_HISTORY'
,'AT_COLLECTION_LOCK'
,'AT_WLK_COLLECTION_LOCK'
,'AT_WORK_LISTS_LOCKS'
,'AT_INTRADAY_UPLOAD_CHARGE_DETAILS'
,'AT_INTRADAY_UPLOAD_CHARGE_FILES'
,'AT_INTRADAY_UPLOAD_FILE_DETAILS'
,'AT_INTRADAY_UPLOAD_FILES'
,'AT_INTRADAY_UPLOAD_FILES_CONFIG'
,'AT_INTRADAY_UPLOAD_FILES_CONFIG_FIELDS'
,'AT_INTRADAY_UPLOAD_FILES_CONFIG_INST'
,'AT_LAW_COURT_CONTACTS'
,'AT_LAW_COURTS'
,'AT_LAWYERS'
,'AT_LEGAL_EXPENSES_EXT'
,'AT_LEGAL_EXPENSES_EXT_ACCOUNTING_ANALYSIS'
,'AT_LEGAL_EXPENSES_EXT_DETAILS'
,'AT_LEGAL_EXPENSES_EXT_DETAILS_HIST'
,'AT_LEGAL_EXPENSES_EXT_HIST'
,'AT_LEGAL_EXPENSES_EXT_LINKED_DOCUMENTS'
,'AT_LEGAL_EXPENSES_TYPE_PRICELISTS'
,'AT_LEGAL_EXPENSES_TYPES'
,'AT_DEBUG_LOG'
,'AT_LOG'
,'AT_BANK_ACCOUNT_ALIAS_NUMBERS'
,'AT_BANK_ACCOUNTS'
,'AT_DD_COLLECTION_REQUESTS'
,'AT_DD_COLLECTION_REQUESTS_XML'
,'AT_DD_COLLECTION_RESPONSES'
,'AT_DIRECT_DEBIT_PAY_TYPES'
,'AT_OVERPAYMENT_FILE'
,'AT_OVERPAYMENT_FILE_DETAIL'
,'AT_OVERPAYMENTS_EXPORTED'
,'AT_PAYERS'
,'AT_PAYMENT_DEBT_ITEMS'
,'AT_PAYMENT_FILES'
,'AT_PAYMENT_MATCHING_INSTALLMENT_TYPES'
,'AT_PAYMENT_METHODS'
,'AT_PAYMENT_METHODS_BANK_ACCOUNTS'
,'AT_PAYMENT_PROVIDER_NETWORKS_CARD_TYPES'
,'AT_PAYMENT_PROVIDER_REQUESTS'
,'AT_PAYMENT_PROVIDER_RESPONSE_CODES'
,'AT_PAYMENT_TRANSFERS'
,'AT_PAYMENT_TYPES'
,'AT_PAYMENT_TYPES_BANK_ACCOUNTS'
,'AT_PAYMENTS'
,'AT_PAYMENTS_ALGORITHMS'
,'AT_PAYMENTS_ALGORITHMS_CUSTOMIZATIONS'
,'AT_PAYMENTS_ALGRORITHMS_INSTALLATIONS'
,'AT_PAYMENTS_CLONING'
,'AT_PAYMENTS_HISTORY'
,'AT_PAYMENTS_ORPHAN'
,'AT_PAYMENTS_ORPHAN_ALLOCATIONS'
,'AT_PAYMENTS_OVP_MESSAGE_ID'
,'AT_PAYMENTS_PENDING'
,'AT_PAYMENTS_RESULT_SESSION'
,'AT_PROMISE_PAYMENTS'
,'AT_SEPA_XML_FILES'
,'AT_SEPA_XML_FILES_DETAILS'
,'AT_PERSONAL_ASSIGNMENT_REQUEST_DETAILS'
,'AT_PERSONAL_ASSIGNMENT_REQUESTS'
,'AT_PORTFOLIO_ADDRESSES'
,'AT_PORTFOLIO_CONTACTS'
,'AT_PORTFOLIO_CONTENT_GENERATION_CONFIGURATIONS'
,'AT_PORTFOLIO_MEMOS'
,'AT_PORTFOLIO_PAYMENT_METHODS'
,'AT_PORTFOLIO_TRANSFER_HEADERS'
,'AT_PORTFOLIO_TRANSFERS'
,'AT_PORTFOLIO_TRANSFERS_LOG'
,'AT_PORTFOLIOS'
,'AT_PORTFOLIOS_CUSTOM_FIELDS'
,'AT_COVENANTS'
,'AT_NON_CIF_CUSTOMERS'
,'AT_PROCESS_OUTSOURCE_MASSIVE'
,'AT_PROCESSES_EXT_BATCH'
,'AT_PROCESSES_EXT_BATCH_COMPANIES'
,'AT_PROCESSES_EXT_BATCH_RECALL_STAGES'
,'AT_PROCESSES_EXT_BATCH_RECALL_STATUSES'
,'AT_PROCESSES_EXT_DCA_PANELS'
,'AT_PROCESSES_EXT_ITEMS'
,'AT_PROCESSES_EXT_PANELS'
,'AT_PROCESSES_EXT_RECALL_BATCH'
,'AT_PROCESSES_EXT_RECALL_TYPES'
,'AT_PROCESSES_SEGMENTS'
,'AT_PROCESSES_SEGMENTS_CRITERIA'
,'AT_PROCESSES_SEGMENTS_CRITERIA_VALUES'
,'AT_PROCESSES_SEGMENTS_ITEMS'
,'AT_PROCESS_DEFINITION_CUSTOM_FIELDS'
,'AT_PROCESS_DEFINITION_CUSTOM_FIELDS_LAYOUT_PARTS'
,'AT_PROCESS_DEFINITION_CUSTOM_FIELDS_LAYOUTS'
,'AT_PROCESS_DEFINITION_GLOBAL_PROP_LAYOUTS'
,'AT_PROCESS_DEFINITION_GLOBAL_PROP_LAYOUTS_FIELDS'
,'AT_PROCESS_DEFINITION_MAPPING'
,'AT_PROCESS_DEFINITION_MAPPING_PARALLEL_STAGES'
,'AT_PROCESS_DEFINITION_MAPPING_STAGES'
,'AT_PROCESS_DEFINITION_MAPPING_STEPS'
,'AT_PROCESS_DEFINITION_OUTCOMES'
,'AT_PROCESS_DEFINITION_PARALLEL_STAGES'
,'AT_PROCESS_DEFINITION_REPLACEMENT_ACTIVITIES'
,'AT_PROCESS_DEFINITION_ROLES'
,'AT_PROCESS_DEFINITION_STAGE_TEAMS'
,'AT_PROCESS_DEFINITION_STAGES'
,'AT_PROCESS_DEFINITION_STAGES_ROLES'
,'AT_PROCESS_DEFINITION_STAGES_TRANSITION_ROLES'
,'AT_PROCESS_DEFINITION_STAGES_TRANSITIONS'
,'AT_PROCESS_DEFINITION_STEP_ALERTS'
,'AT_PROCESS_DEFINITION_STEP_MAPPINGS'
,'AT_PROCESS_DEFINITION_STEPS'
,'AT_PROCESS_DEFINITION_SUBPROCESSES'
,'AT_PROCESS_DEFINITION_TEAMS'
,'AT_PROCESS_DEFINITION_WO_TYPE_OUTCOMES'
,'AT_PROCESS_DEFINITION_WO_TYPE_PROCESS_USAGE'
,'AT_PROCESS_DEFINITION_WO_TYPES'
,'AT_PROCESS_DEFINITIONS'
,'AT_PROCESS_DEFINITIONS_EXTENSION'
,'AT_PROCESS_INSTANCE_ACCOUNTS'
,'AT_PROCESS_INSTANCE_ACCOUNTS_SNAPSHOT'
,'AT_PROCESS_INSTANCE_ACCOUNTS_SNAPSHOT_VERSION'
,'AT_PROCESS_INSTANCE_ACTIVITIES'
,'AT_PROCESS_INSTANCE_ACTIVITIES_STAGING'
,'AT_PROCESS_INSTANCE_ARRANGEMENTS'
,'AT_PROCESS_INSTANCE_COLLATERALS'
,'AT_PROCESS_INSTANCE_COVENANTS'
,'AT_PROCESS_INSTANCE_GENERIC'
,'AT_PROCESS_INSTANCE_IMMOV_PROPERTIES'
,'AT_PROCESS_INSTANCE_LINKED_DOCUMENTS'
,'AT_PROCESS_INSTANCE_MAPPING_ACTIVITIES'
,'AT_PROCESS_INSTANCE_MASS_UNFREEZE'
,'AT_PROCESS_INSTANCE_MASS_UNFREEZE_DETAILS'
,'AT_PROCESS_INSTANCE_OPEN_STEPS_INFO'
,'AT_PROCESS_INSTANCE_PARALLEL_STAGES'
,'AT_PROCESS_INSTANCE_PARALLEL_STAGES_DELETED'
,'AT_PROCESS_INSTANCE_PARTICIPANT_STEPS'
,'AT_PROCESS_INSTANCE_PARTICIPANTS'
,'AT_PROCESS_INSTANCE_SOLUTIONS'
,'AT_PROCESS_INSTANCE_STAGE_ACTIVITIES_STAGING'
,'AT_PROCESS_INSTANCE_STAGE_TRANSITION_REQUESTS'
,'AT_PROCESS_INSTANCE_STAGES'
,'AT_PROCESS_INSTANCE_STEPS'
,'AT_PROCESS_INSTANCE_STEPS_DELETED'
,'AT_PROCESS_INSTANCE_TIMELINE_ENTRIES'
,'AT_PROCESS_INSTANCE_WO'
,'AT_PROCESS_INSTANCE_WO_DETAILS'
,'AT_PROCESS_INSTANCES'
,'AT_PMS_QUERIES'
,'AT_PMS_QUERY_MESSAGES'
,'AT_UPLOAD_MANUAL_CONFIGURATION'
,'AT_CASE_QUEUE_HISTORY'
,'AT_CASES_CLOSED_MANUAL_QUEUE'
,'AT_QUEUES'
,'AT_QUEUES_CRITERIA'
,'AT_QUEUES_CRITERIA_ORDER'
,'AT_QUEUES_CRITERIA_VALUES'
,'AT_QUEUES_DEPARTMENTS'
,'AT_QUEUES_GROUPS'
,'AT_QUEUES_HISTORY'
,'AT_QUEUES_LOG'
,'AT_QUEUES_ORDER'
,'AT_QUEUES_RUN_HISTORY'
,'AT_QUEUES_SNAP'
,'AT_TEAMS_QUEUES'
,'AT_UPLOAD_MANUAL_CONFIGURATION_INSTALLATIONS'
,'AT_USER_REPORT_PERMISSIONS'
,'AT_USER_REPORTS'
,'AT_STRATEGY_CASE_ASSIGNMENTS'
,'AT_STRATEGY_CASE_ASSIGNMENTS_HISTORY'
,'AT_STRATEGY_CASE_ASSIGNMENTS_STATIC'
,'AT_STRATEGY_CASE_EXCLUSIONS_HISTORY'
,'AT_STRATEGY_CASE_EXIT_INSTALLATIONS'
,'AT_STRATEGY_CASE_EXIT_REASONS'
,'AT_STRATEGY_CASE_RESTART_BUCKET_ASSIGNMENT'
,'AT_STRATEGY_CASE_TRANSITIONS_HISTORIC'
,'AT_STRATEGY_CASE_TRANSITIONS_HISTORY'
,'AT_STRATEGY_CASE_TRANSITIONS_HISTORY_EOD'
,'AT_STRATEGIES'
,'AT_STRATEGY_AREAS'
,'AT_STRATEGY_COMMUNICATION_SCRIPTS'
,'AT_STRATEGY_COUNTER_PROPERTIES'
,'AT_STRATEGY_EXT_EVENTS_RESTARTS'
,'AT_STRATEGY_EXTERNAL_ASSIGNMENT_TYPE_AGENCIES'
,'AT_STRATEGY_EXTERNAL_ASSIGNMENT_TYPES'
,'AT_STRATEGY_EXTERNAL_ASSIGNMENT_TYPES_ADV_DEPS'
,'AT_STRATEGY_EXTERNAL_ASSIGNMENT_TYPES_EXP_DEPS'
,'AT_STRATEGY_EXTERNAL_EVENTS'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_SNAPSHOT'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPE_ORDER_CONFIG'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPE_ORDER_RUNNING'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPE_RELATION_CONF'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPE_TEAMS_CONFIG'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPE_TEAMS_RUNNING'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPES'
,'AT_STRATEGY_INTERNAL_ASSIGNMENT_TYPES_RELATIONS'
,'AT_STRATEGY_ORDER_CRITERIA'
,'AT_STRATEGY_ORDER_CRITERIA_RUNNING'
,'AT_STRATEGY_QUEUES_ORDERING_CONFIGURED'
,'AT_STRATEGY_QUEUES_ORDERING_RUNNING'
,'AT_STRATEGY_RECALL_CASES_PACKET_TYPES'
,'AT_STRATEGY_UNIVERSES'
,'AT_STRATEGY_VERSION_FLOWS'
,'AT_STRATEGY_VERSION_TRANSFER_MAPPING'
,'AT_STRATEGY_VERSION_TRANSFERS'
,'AT_STRATEGY_VERSIONS'
,'AT_WORKFLOW_LOG'
,'AT_CASE_STREAMS'
,'AT_CASE_STREAMS_HIST'
,'AT_CUSTOMER_STREAM_EXCLUSIONS'
,'AT_CUSTOMER_STREAM_EXCLUSIONS_HIST'
,'AT_CUSTOMER_STREAMS'
,'AT_CUSTOMER_STREAMS_HIST'
,'AT_CUSTOMER_STREAMS_HIST_BU'
,'AT_STREAM_STATUS_ACTIVITY'
,'AT_STREAM_STATUS_TRANS'
,'AT_WORK_LISTS_TYPES'
,'AT_WORK_LISTS_TYPES_COUNTERS'
,'AT_DEBT_TO_RELATION_FIELD_MAPPING'
,'AT_NOAUDITEDTABLES'
,'AT_ORDER_CRITERIA_STATIC'
,'AT_ORDER_CRITERIA_STATIC_INSTALLATION'
,'Enterprises'
,'TableFields'
,'Tables'
,'AT_COUNTRIES'
,'AT_ASSET_CLASSES'
,'AT_AUTOCREATED_TASKS'
,'AT_BRANCHES'
,'AT_BRANCHES_GROUPS'
,'AT_BRANCHES_GROUPS_MEMBERS'
,'AT_COMPANIES'
,'AT_CONFIG_TRANSFER_HISTORY'
,'AT_CURRENCIES'
,'AT_CUSTOMER_CONTACT_CONFIRMATION'
,'AT_CUSTOMER_CONTACT_CONFIRMATION_QUESTIONS'
,'AT_CUSTOMER_CONTACT_QUESTIONS'
,'AT_EXCHANGE_RATES'
,'AT_GROUPS'
,'AT_HOLIDAYS'
,'AT_LEGAL_ENTITIES'
,'AT_LOCALIZATION_LANGUAGES'
,'AT_LOV_TYPES'
,'AT_LST_OF_VAL'
,'AT_LST_OF_VAL_HISTORY'
,'AT_LST_OF_VAL_LOCALIZATION'
,'AT_PRODUCTS'
,'AT_PROMISE_PARAMETERS'
,'AT_RELATION_TYPES_MAPPING_FUTURE'
,'AT_RELATION_TYPES_MAPPING_RUNNING'
,'AT_RESET_STATUS'
,'AT_RESP_STATE_MODEL_GROUP'
,'AT_STATE_MODEL'
,'AT_STATE_MODEL_ACTIV'
,'AT_STATE_MODEL_AUTOMATIC_ACTIVITIES'
,'AT_STATE_MODEL_GROUP'
,'AT_STATE_MODEL_GROUP_TRANSITIONS'
,'AT_SUBPROD_CYCLE'
,'AT_SUBPRODUCTS'
,'AT_SYSTEM_PREF'
,'AT_TEAM_MEMBERS'
,'AT_TEAMS'
,'AT_UI_AUDIT_CUSTOMER_LOCK'
,'AT_UI_AUDIT_ENTITY_SELECTION'
,'AT_UI_AUDIT_ENTITY_SELECTION_MONITORED'
,'AT_UI_AUDIT_QBE'
,'AT_UI_AUDIT_QBE_MONITORED'
,'AT_APPLICATION_CAPABILITIES'
,'AT_ACTIONS'
,'AT_API_CLIENT_CREDENTIALS'
,'AT_API_CLIENT_PERMISSIONS'
,'AT_DEPARTMENT_MANAGE_TYPE'
,'AT_DEPARTMENT_QUEUE_TYPE'
,'AT_DEPARTMENTS'
,'AT_EMP_PWD_HIST'
,'AT_EMP_RESP'
,'AT_EMPLOYEES'
,'AT_RESP_ACTIONS'
,'AT_RESPONSIBILITIES'
,'AT_ROLE_CAPABILITIES'
,'AT_ROLE_MEMBERS'
,'AT_ROLES'
,'AT_WORK_STATIONS'
,'AT_BARCODE_DYNAMIC_CONFIGURATION_FIELDS'
,'AT_BARCODE_DYNAMIC_CONFIGURATIONS'
,'AT_BARCODE_DYNAMIC_FIELDS'
,'AT_DOCUMENTS_UPLOAD_FILES'
,'AT_LETTER_ATTACHMENTS'
,'AT_LT_CONT_GEN_CONF_MULTILINGUAL_TEMPLATES'
,'AT_LT_CONTENT_DISPATCH_ACTION_CONFIG'
,'AT_LT_CONTENT_GENERATION_ACTION_CONFIG'
,'AT_LT_CONTENT_GENERATION_CONFIG_DETAIL_SETTINGS'
,'AT_LT_CONTENT_GENERATION_CONFIGURATIONS'
,'AT_LT_CONTENT_GENERATION_DETAILS_DATA'
,'AT_LT_CONTENT_GENERATION_DISPATCH_DATA'
,'AT_LT_CONTENT_GENERATION_EXECUTION'
,'AT_LT_CONTENT_GENERATION_EXECUTION_STRATEGY'
,'AT_LT_CONTENT_GENERATION_MASTER_DATA'
,'AT_LT_CONTENT_GENERATION_TEMPLATE_DETAILS'
,'AT_LT_CONTENT_GENERATION_TEMPLATE_ROLES'
,'AT_LT_CONTENT_GENERATION_TEMPLATES'
,'AT_LT_CONTENT_GENERATION_UNIQUE_KEYS'
,'AT_LT_DISPATCH_PROVIDERS'
,'AT_LT_OMNICHANNEL_BOT_TEMPLATE_STEPS'
,'AT_LT_OMNICHANNEL_BOT_TEMPLATES'
,'AT_LT_OMNICHANNEL_CONTENT_BOT_INFO_STEPS'
,'AT_LT_OMNICHANNEL_CONTENT_CAMPAIGNS'
,'AT_LT_TEMPLATE_CALCULATED_FIELDS'
,'AT_WBC_AGGREGATED_FIELD_OPERATIONS'
,'AT_DELTA_DATA_ACTIVITIES'
,'AT_DELTA_DATA_ADDRESSES'
,'AT_DELTA_DATA_ALLOCATION_MOVEMENTS'
,'AT_DELTA_DATA_ALLOCATION_PROCESSING'
,'AT_DELTA_DATA_CASE_MEMOS'
,'AT_DELTA_DATA_CLOSURES'
,'AT_DELTA_DATA_CONTACT_DETAILS'
,'AT_DELTA_DATA_CONTACT_PERSONS'
,'AT_DELTA_DATA_CONTROL_LOG'
,'AT_DELTA_DATA_CUST_EVENTS'
,'AT_DELTA_DATA_CUSTOMERS'
,'AT_DELTA_DATA_EVENTS'
,'AT_DELTA_DATA_INTERNET_IDS'
,'AT_DELTA_DATA_NEW_PLACEMENTS'
,'AT_DELTA_DATA_OWNERSHIP_RIGHTS_DAILY'
,'AT_DELTA_DATA_PAYMENTS'
,'AT_DELTA_DATA_PHONES'
,'AT_DELTA_DATA_PORTFOLIO_SNAP'
,'AT_DELTA_DATA_PRIN_ACTIVITIES'
,'AT_DELTA_DATA_PROCESS_INSTANCES'
,'AT_DELTA_DATA_PROMISES_SNAP'
,'AT_DELTA_DATA_PROPERTY_OWNERS_CNT_DETAILS_DAILY'
,'AT_DELTA_DATA_PROPERTY_RIGHT_VALUATIONS_DAILY'
,'AT_DELTA_DATA_PROPERTY_VALUATIONS_DAILY'
,'AT_DELTA_DATA_REAL_PROPERTY_DAILY'
,'AT_DELTA_DATA_REPAYMENT_CASES'
,'AT_DELTA_DATA_REPAYMENT_OFFERS'
,'AT_DELTA_DATA_REPAYMENT_OFFERS_PLAN'
,'AT_DELTA_DATA_TRANSACTIONS'
,'AT_DELTA_REAL_PROPERTY_INTEREST_DAILY'
,'AT_TEAM_INSTRUCTION_ITEM_SESSIONS'
,'AT_TEAM_INSTRUCTION_ITEMS'
,'AT_TEAM_INSTRUCTIONS'
,'AT_WORK_LISTS'
,'AT_WORK_LISTS_CASES'
,'AT_WORK_LISTS_CASES_RELEASE_REASON'
,'AT_WORK_LISTS_CLOSED_CRITERIA'
,'AT_WORK_LISTS_CLOSED_CRITERIA_VALUES'
,'AT_WORK_LISTS_CRITERIA'
,'AT_WORK_LISTS_CRITERIA_VALUES'
,'AT_WORK_LISTS_ORDER'
,'AT_WORK_LISTS_PACKET_SOURCE'
,'AT_WORK_LISTS_PACKET_TYPES'
,'AT_WORK_LISTS_RUN_HIST'
,'AT_WORK_LISTS_SOURCE'
,'AT_WORK_LISTS_TEAMS'
,'AT_WORK_LISTS_TEAMS_STATISTICS'
,'AT_IMPORT_EXPORT'
,'AT_LT_TEMPLATE_UPDATABLE_FIELDS'
,'AT_MAPPING_TYPE_VENDOR'
,'AT_MAPPING_TYPE_VENDOR_VALUES'
,'AT_MAPPING_TYPES'

)

 ORDER BY DMTF_TABLE_NAME, COLUMN_ID